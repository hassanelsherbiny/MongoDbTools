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
    public partial class ConnectionsFrm : Form
    {
        public ConnectionsFrm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnNewConnection_Click(object sender, EventArgs e)
        {
            (new NewConnectionFrm()).ShowDialog();
            ConnectionsGrid.DataSource = Session.Settings.Servers;
        }

        private void ConnectionsFrm_Load(object sender, EventArgs e)
        {
            ConnectionsGrid.DataSource = Session.Settings.Servers.ToList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           
            if (ConnectionsGrid.SelectedRows.Count == 0)
            {
                LoadingImg.Visible = false;
                MessageBox.Show("Please Select Sever To Connect To"); 
            }
            else
            {
                ConnectionsGrid.Enabled = BtnConnect.Enabled = false;
                int ConnectionIndex = ConnectionsGrid.Rows.IndexOf(ConnectionsGrid.SelectedRows[0]);
                var server = Session.Settings.Servers[ConnectionIndex];
                if (MongoGeneralLogic.TryToConnectToServer(server))
                {
                    Session.CurrentConnections.Add(server);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    LoadingImg.Visible = false;
                    ConnectionsGrid.Enabled = BtnConnect.Enabled = true;
                    MessageBox.Show("Failed To Connect To Server");

                }
            }
        }

        private void ConnectionsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadingImg.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            LoadingImg.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ConnectionsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Sever To Connect To");
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Connection?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int ConnectionIndex = ConnectionsGrid.Rows.IndexOf(ConnectionsGrid.SelectedRows[0]);
                    Session.Settings.Servers.RemoveAt(ConnectionIndex);
                    Session.Settings.Save();
                    ConnectionsGrid.DataSource = Session.Settings.Servers.ToList();
                }


            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            (new NewConnectionFrm(ConnectionsGrid.SelectedRows[0].Index)).ShowDialog();
            ConnectionsGrid.DataSource = Session.Settings.Servers;
        }

        private void ConnectionsGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = ConnectionsGrid.HitTest(e.X, e.Y);
                ConnectionsGrid.ClearSelection();
                ConnectionsGrid.Rows[hti.RowIndex].Selected = true;
            }
        }
    }
}
