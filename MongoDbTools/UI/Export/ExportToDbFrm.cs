using MongoConnection.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class ExportToDbFrm : Form
    {
        string Sourceconnectionstring, SourceDbName, TargetConnection;
        List<string> SelectedCollection;
        public ExportToDbFrm(string Sourceconnectionstring, string SourceDbName, List<string> SelectedCollection)
        {
            InitializeComponent();
            ConnectionsGrid.DataSource = Session.Settings.Servers.ToList();
            this.Sourceconnectionstring = Sourceconnectionstring;
            this.SourceDbName = SourceDbName;
            this.SelectedCollection = SelectedCollection;

        }

        private void BtnNewConnection_Click(object sender, EventArgs e)
        {
            (new NewConnectionFrm()).ShowDialog();
            ConnectionsGrid.DataSource = Session.Settings.Servers;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkCreateDatabase_CheckedChanged(object sender, EventArgs e)
        {
            PnlNewDb.Visible = ChkCreateDatabase.Checked;
            ConnectionTree.Visible = !ChkCreateDatabase.Checked;

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string DbName = "";
            if (!ChkCreateDatabase.Checked)
            {
                if (ConnectionTree.SelectedNode == null)
                {
                    MessageBox.Show("Please Select a db Or Choose To Create New");
                    return;
                }
                else
                {
                    DbName = (ConnectionTree.SelectedNode as DbTreeNode).DbName;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(TxtNewDbName.Text))
                {
                    MessageBox.Show("Please Enter Db Name");
                    return;
                }
                else
                    DbName = TxtNewDbName.Text;
            }

            Main mainfrm = null;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is Main)
                    mainfrm = Application.OpenForms[i] as Main;
            }
            string log = "";
            MongoGeneralLogic.ExportToDb(Sourceconnectionstring,
                              SourceDbName, SelectedCollection, TargetConnection, DbName, out log);
            mainfrm.RunAsyncTask((x, ee) =>
            {

            },
            (x, ee) =>
            {
                MessageBox.Show("Export Done");
            }
            );
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConnectionsGrid_SelectionChanged(object sender, EventArgs e)
        {
            ConnectionTree.Nodes.Clear();
            if (ConnectionsGrid.SelectedRows.Count > 0)
            {
                int SelectedIndex = ConnectionsGrid.Rows.IndexOf(ConnectionsGrid.SelectedRows[0]);
                var CurrentConnection = Session.Settings.Servers[SelectedIndex];
                var ConnectionDb = MongoGeneralLogic.GetServerDataBases(CurrentConnection);
                string ConnectionName = !string.IsNullOrEmpty(CurrentConnection.ConnectionAlias) ? CurrentConnection.ConnectionAlias : CurrentConnection.Server;
                TargetConnection = CurrentConnection.ConnectionString;
                foreach (var db in ConnectionDb)
                {
                    var dbTreeNode = new DbTreeNode()
                    {
                        Text = db,
                        Name = "Db_" + db,
                        //ImageIndex = 1, 
                        DbName = db,
                        ServerConnectionString = CurrentConnection.ConnectionString
                    };
                    ConnectionTree.Nodes.Add(dbTreeNode);
                }
            }
        }
    }
}
