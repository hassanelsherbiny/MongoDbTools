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
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //BackGroundTasksPanel.Controls.Add(new LoadingItem());
            //MongoGeneralLogic.Import();
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
                if (!dbTreeNode.Loaded)
                {
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

                            //  ContextMenuStrip = DbContextMenu,
                            DbName = dbTreeNode.DbName,
                            CollectionName = item,
                            ServerConnectionString = dbTreeNode.ServerConnectionString
                        };
                        dbTreeNode.Nodes.Add(collectionTreeNode);
                    }
                    dbTreeNode.Loaded = true;


                }
            }
        }

        private void ConnectionTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (!string.IsNullOrEmpty(e.Node.Name) && e.Node.Name.StartsWith("Collection_"))
            //{
            //    var collectionTreeNode = e.Node as CollectionTreeNode;
            //    var collection = MongoGeneralLogic.LoadCollection(collectionTreeNode.ServerConnectionString,
            //        collectionTreeNode.DbName, collectionTreeNode.CollectionName);
            //    dataGridView1.DataSource = collection;
            //}
        }

        private void BtnServerRefresh_Click(object sender, EventArgs e)
        {

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
            ExportFrm frm = new ExportFrm(dbNode.ServerConnectionString, dbNode.DbName);
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
            ImportFromJsonFrm frm = new ImportFromJsonFrm(dbNode.ServerConnectionString, dbNode.DbName);
            frm.ShowDialog();
        }

        private void ConnectionTree_DoubleClick(object sender, EventArgs e)
        {
            if (ConnectionTree.SelectedNode is CollectionTreeNode)
            {
                var CollectionNode = ConnectionTree.SelectedNode as CollectionTreeNode;
                //dataGridView2.DataSource = MongoGeneralLogic.GetCollection(CollectionNode.ServerConnectionString, CollectionNode.DbName, CollectionNode.CollectionName);

            }
        }

        private void BtnRestoreDb_Click(object sender, EventArgs e)
        {
            var serverNode = ConnectionTree.SelectedNode as ServerTreeNode;
            var frm = new ImportDumpFrm(serverNode.ServerConnectionString);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var server = Session.CurrentConnections.FirstOrDefault(x => x.ConnectionString == serverNode.ServerConnectionString);
                ConnectionTree.Nodes.Remove(serverNode);
                NewConnection(server);
                Session.CurrentConnections.Remove(server);
            }
        }
    }
}

