using MongoConnection.Data;
using MongoConnection.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MongoDbTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            CollectionExplorer.DrawMode = TabDrawMode.OwnerDrawFixed;
            CollectionExplorer.DrawItem += CollectionExplorer_DrawItem;
            CollectionExplorer.Padding = new Point(10, 3);

        }
        private void CollectionExplorer_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            var _imageLocation = new Point(19, 5);
            try
            {
                Image img = new Bitmap(MongoDbTools.Properties.Resources.delete_16x16);
                Rectangle r = e.Bounds;
                r = this.CollectionExplorer.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.CollectionExplorer.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));


                e.Graphics.DrawImage(img, new Point(r.X + (this.CollectionExplorer.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));

            }
            catch (Exception) { }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Session.Settings.StartLocalServiceWithStartUp)
                MongoGeneralLogic.StartLocalHost(Session.Settings.MongoInstallationPath, Session.Settings.LocalHostDataFilesPath);
            //NewConnection();
            NewConnection(Session.Settings.Servers.FirstOrDefault());
        }

        void NewConnection(MDTServer server = null)
        {
            var c = new ConnectionsFrm();
            if (server != null || c.ShowDialog() == DialogResult.OK)
            {
                var CurrentConnection = server ?? Session.CurrentConnections.Last();
                var ConnectionDb = MongoGeneralLogic.GetServerDataBases(CurrentConnection);
                string ConnectionName = !string.IsNullOrEmpty(CurrentConnection.ConnectionAlias) ? CurrentConnection.ConnectionAlias : CurrentConnection.Server;
                ServerTreeNode connectionNode = new ServerTreeNode()
                {
                    Text = ConnectionName,
                    ImageIndex = 0,
                    ServerConnectionString = CurrentConnection.ConnectionString,
                    Server = CurrentConnection,
                    ContextMenuStrip = ServerContextMenu,
                };
                foreach (var db in ConnectionDb)
                {
                    var dbTreeNode = new DbTreeNode()
                    {
                        Text = db,
                        Name = "Db_" + db,
                        ImageIndex = 1,
                        ContextMenuStrip = DbContextMenu,
                        DbName = db,
                        Server = CurrentConnection,
                        ServerConnectionString = CurrentConnection.ConnectionString
                    };
                    dbTreeNode.Nodes.Add("");

                    connectionNode.Nodes.Add(dbTreeNode);
                }
                ConnectionTree.Nodes.Add(connectionNode);
                connectionNode.Expand();
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            NewConnection();
        }

        private void ConnectionTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name) && e.Node.Name.StartsWith("Db_"))
            {
                var dbTreeNode = e.Node as DbTreeNode;
                dbTreeNode.Nodes.Clear();
                var DbCollections = MongoGeneralLogic.GetDatabaseCollections(dbTreeNode.ServerConnectionString, dbTreeNode.DbName);
                foreach (var item in DbCollections)
                {
                    var collectionTreeNode = new CollectionTreeNode()
                    {
                        Text = item,
                        Name = "Collection_" + item,
                        ImageIndex = 2,
                        SelectedImageIndex = 1,
                        ContextMenuStrip = CollectionContext,
                        DbName = dbTreeNode.DbName,
                        CollectionName = item,
                        Server = dbTreeNode.Server
                    };
                    dbTreeNode.Nodes.Add(collectionTreeNode);
                }
                ConnectionTree.SelectedNode = e.Node;
            }
        }


        private void BtnServerRefresh_Click(object sender, EventArgs e)
        {
            var serverNode = ConnectionTree.SelectedNode as ServerTreeNode;
            var CurrentConnectionString = serverNode.ServerConnectionString;

            ConnectionTree.Nodes.Remove(serverNode);
            NewConnection(new MDTServer() { ConnectionString = CurrentConnectionString, Server = serverNode.Text });
        }

        private void BtnAddDataBase_Click(object sender, EventArgs e)
        {
            var serverNode = ConnectionTree.SelectedNode as ServerTreeNode;
            var createDbFrm = new NewDbFrm(serverNode.ServerConnectionString);
            if (createDbFrm.ShowDialog() == DialogResult.OK)
            {
                var server = Session.CurrentConnections.FirstOrDefault(x => x.ConnectionString == serverNode.ServerConnectionString);
                ConnectionTree.Nodes.Remove(serverNode);
                NewConnection(server);
                Session.CurrentConnections.Remove(server);
            }
        }

        private void BtnDropDatabase_Click(object sender, EventArgs e)
        {
            var dbTreeNode = ConnectionTree.SelectedNode as DbTreeNode;
            if (dbTreeNode != null)
            {
                if (MessageBox.Show("Are you sure you want to delete This Database?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MongoGeneralLogic.DropDataBase(dbTreeNode.ServerConnectionString, dbTreeNode.DbName);
                        dbTreeNode.Parent.Nodes.Remove(dbTreeNode);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed To Drop Database.\n" + ex.Message);
                    }
                }
            }


        }

        private void ConnectionTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                ConnectionTree.SelectedNode = ConnectionTree.GetNodeAt(e.X, e.Y);

            }
        }

        private void LocalHostChecker_Tick(object sender, EventArgs e)
        {
            var localHostProcess = Process.GetProcessesByName("mongod");
            if (localHostProcess.Length == 0)
            {
                LblLocalHostState.Text = "Stopped";
                BtnLocalHostStop.Enabled = false;
                BtnLocalHostRestart.Enabled = false;
                BtnLocalHostStart.Enabled = true;
                LblLocalHostState.ForeColor = Color.Red;
            }
            else
            {
                LblLocalHostState.Text = "Running";
                LblLocalHostState.ForeColor = Color.Green;
                BtnLocalHostStart.Enabled = false;
                BtnLocalHostStop.Enabled = true;
                BtnLocalHostRestart.Enabled = true;
            }


        }

        private void BtnLocalHostStart_Click(object sender, EventArgs e)
        {
            MongoGeneralLogic.StartLocalHost(Session.Settings.MongoInstallationPath, Session.Settings.LocalHostDataFilesPath);
        }

        private void BtnLocalHostStop_Click(object sender, EventArgs e)
        {
            MongoGeneralLogic.StopLocalHost();
        }

        private void BtnLocalHostRestart_Click(object sender, EventArgs e)
        {
            MongoGeneralLogic.RestatLocalHost(Session.Settings.MongoInstallationPath, Session.Settings.LocalHostDataFilesPath);
        }

        private void BtnExportDb_Click(object sender, EventArgs e)
        {
            var dbNode = ConnectionTree.SelectedNode as DbTreeNode;
            ExportFrm frm = new ExportFrm(dbNode.Server, dbNode.DbName, new List<string>());
            frm.ShowDialog();
        }



        public void RunAsyncTask(DoWorkEventHandler work, RunWorkerCompletedEventHandler WorkDone)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += work;
            worker.RunWorkerCompleted += WorkDone;
            worker.ProgressChanged += (S, E) =>
            {


            };
            worker.RunWorkerAsync();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var dbNode = ConnectionTree.SelectedNode as DbTreeNode;
            //ImportFromJsonFrm frm = new ImportFromJsonFrm(dbNode.ServerConnectionString, dbNode.DbName);
            //frm.ShowDialog();
            var frm = new ImportDumpFrm(dbNode.DbName, dbNode.Server);
            frm.ShowDialog();
        }

        private void ConnectionTree_DoubleClick(object sender, EventArgs e)
        {
            if (ConnectionTree.SelectedNode is CollectionTreeNode)
            {
                var CollectionNode = ConnectionTree.SelectedNode as CollectionTreeNode;
                var collectionExplorertab = new CollectionExplorerTab(CollectionNode.Server.ConnectionString, CollectionNode.DbName, CollectionNode.CollectionName);
                collectionExplorertab.Server = CollectionNode.Server;
                var tab = new TabPage();
                collectionExplorertab.Dock = DockStyle.Fill;
                tab.Controls.Add(collectionExplorertab);
                tab.Text = CollectionNode.CollectionName;
                CollectionExplorer.Controls.Add(tab);
                CollectionExplorer.SelectedTab = tab;
            }
        }

        private void BtnRestoreDb_Click(object sender, EventArgs e)
        {
            var serverNode = ConnectionTree.SelectedNode as ServerTreeNode;
            var CurrentConnectionString = serverNode.ServerConnectionString;
            var frm = new ImportDumpFrm(serverNode.Server);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ConnectionTree.Nodes.Remove(serverNode);
                NewConnection(new MDTServer() { ConnectionString = CurrentConnectionString, Server = serverNode.Text });
            }
        }

        private void CollectionExplorer_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CollectionExplorer_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = CollectionExplorer.GetTabRect(this.CollectionExplorer.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                this.CollectionExplorer.TabPages.Remove(this.CollectionExplorer.SelectedTab);
            }
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < CollectionExplorer.TabCount; ++i)
                {
                    if (CollectionExplorer.GetTabRect(i).Contains(e.Location))
                    {
                        CollectionExplorer.SelectedTab = CollectionExplorer.TabPages[i];
                    }
                }
                this.CollectionExplorerMenu.Show(this.CollectionExplorer, e.Location);
            }
        }

        private void BtnDeleteCollection_Click(object sender, EventArgs e)
        {
            var CollectionNode = ConnectionTree.SelectedNode as CollectionTreeNode;
            string Message = string.Format("Are You Sure You want to delete '{0}' Collection", CollectionNode.CollectionName);
            if (MessageBox.Show(this, Message, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MongoGeneralLogic.DropCollection(CollectionNode.Server.ConnectionString, CollectionNode.DbName, CollectionNode.CollectionName);
                var parent = CollectionNode.Parent;
                parent.Collapse();
                parent.Expand();
                //Close All Open Tabs OF Collection Explorer
                foreach (TabPage ParentTab in CollectionExplorer.TabPages)
                {
                    CollectionExplorerTab tab = ParentTab.Controls[0] as CollectionExplorerTab;
                    if (tab.Server == CollectionNode.Server && tab.CollectionName == CollectionNode.CollectionName && tab.DbName == CollectionNode.DbName)
                    {
                        CollectionExplorer.TabPages.Remove(tab.Parent as TabPage);
                    }
                }
            }

        }

        private void ConnectionTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (ConnectionTree.SelectedNode != null)
            {
                if (ConnectionTree.SelectedNode is DbTreeNode)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        BtnDropDatabase_Click(null, null);
                    }
                }
                else if (ConnectionTree.SelectedNode is CollectionTreeNode)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        BtnDeleteCollection_Click(null, null);
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var collectionNode = ConnectionTree.SelectedNode as CollectionTreeNode;
            ExportFrm frm = new ExportFrm(collectionNode.Server, collectionNode.DbName, new List<string>() { collectionNode.CollectionName });
            frm.ShowDialog();
        }

        private void BtnServerDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectServer();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectServer();
        }
        void DisconnectServer()
        {
            var currentServerNode = ConnectionTree.SelectedNode as BaseTreeNode;
            if (currentServerNode is DbTreeNode)
                currentServerNode = currentServerNode.Parent as BaseTreeNode;
            if (currentServerNode is CollectionTreeNode)
                currentServerNode = currentServerNode.Parent.Parent as BaseTreeNode;
            ConnectionTree.Nodes.Remove(currentServerNode);
            foreach (Control item in CollectionExplorer.TabPages)
            {
                if ((item.Controls[0] as CollectionExplorerTab).Server == currentServerNode.Server)
                {
                    CollectionExplorer.Controls.Remove(item);
                }
            }
        }

        private void BtnImportJson_Click(object sender, EventArgs e)
        {
            var dbNode = ConnectionTree.SelectedNode as DbTreeNode;
            var frm = new ImportFromJsonFrm(dbNode.DbName, dbNode.Server);
            frm.ShowDialog();
            dbNode.Collapse();
            dbNode.Expand();
        }
        #region Close Tabs
        private void BtnCloseTabExplorer_Click(object sender, EventArgs e)
        {
            CollectionExplorer.TabPages.Remove(CollectionExplorer.SelectedTab);
        }

        private void BtnCloseAllTabs_Click(object sender, EventArgs e)
        {
            CollectionExplorer.TabPages.Clear();
        }

        private void BtnCloseAllButThis_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.CollectionExplorer.TabPages)
            {
                if (tab != CollectionExplorer.SelectedTab)
                    CollectionExplorer.TabPages.Remove(tab);
            }
        }

        private void BtnCloseTabsToRight_Click(object sender, EventArgs e)
        {
            int CurrentTabIndex = CollectionExplorer.TabPages.IndexOf(CollectionExplorer.SelectedTab);
            for (int i = CollectionExplorer.TabPages.Count - 1; i > CurrentTabIndex; i--)
            {
                var tab = CollectionExplorer.TabPages[i];
                CollectionExplorer.TabPages.Remove(tab);
            }
        }

        private void BtnCloseTabsToLeft_Click(object sender, EventArgs e)
        {
            int CurrentTabIndex = CollectionExplorer.TabPages.IndexOf(CollectionExplorer.SelectedTab);
            for (int i = CurrentTabIndex - 1; i >= 0; i--)
            {
                var tab = CollectionExplorer.TabPages[i];
                CollectionExplorer.TabPages.Remove(tab);
            }
        }

        #endregion

        private void BtnMigrator_Click(object sender, EventArgs e)
        {
            FrmMigrations frm = new FrmMigrations();
            if (ConnectionTree.SelectedNode is DbTreeNode)
            {
                var dbNode = ConnectionTree.SelectedNode as DbTreeNode; 
                frm.SelectedMigrator = new MDTMigratorFile()
                {
                    SourceDb = dbNode.DbName,
                    SourceServer = dbNode.Server
                };
              
            }
            frm.ShowDialog();
        }

        private void BtnRpt_Click(object sender, EventArgs e)
        {
            var dbNode = ConnectionTree.SelectedNode as DbTreeNode;
            FrmCollectionRpt frm = new FrmCollectionRpt(dbNode.Server, dbNode.DbName);
            frm.ShowDialog();
        }
    }
}

