using MongoConnection.Data;
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
    public partial class NewConnectionFrm : Form
    {
        int? OnEditServer;
        public NewConnectionFrm()
        {
            InitializeComponent();
            RdAuth_CheckedChanged(null, null);
            CheckForIllegalCrossThreadCalls = false;
        }
        public NewConnectionFrm(int ServerIndex) : this()
        {
            var server = Session.Settings.Servers[ServerIndex];
            OnEditServer = ServerIndex;
            TxtAuthDb.Text = server.AuthDb;
            TxtPassword.Text = server.Password;
            NumPort.Value = server.Port;
            TxtUserName.Text = server.UserName;
            TxtServer.Text = server.Server;
            TxtConnectionName.Text = server.ConnectionAlias;
            RdAuth.Checked = server.UseAuth;
            ChkLocalServer.Checked = server.IsLocal;
            RdAuth_CheckedChanged(null, null);
        }
        MDTServer GetServer()
        {

            MDTServer server = new MDTServer()
            {
                AuthDb = TxtAuthDb.Text,
                Password = TxtPassword.Text,
                UserName = TxtUserName.Text,
                Port = (int)NumPort.Value,
                Server = TxtServer.Text,
                ConnectionAlias = TxtConnectionName.Text,
                UseAuth = RdAuth.Checked,
                IsLocal = ChkLocalServer.Checked
            };
            return server;
        }
        bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(TxtServer.Text))
            {
                MessageBox.Show("Please Enter Server");
                return false;

            }
            return true;
        }
        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                LoadingImg.Visible = true;
                InputPnl.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '*')
                TxtPassword.PasswordChar = '\0';
            else
                TxtPassword.PasswordChar = '*';
        }

        private void RdAuth_CheckedChanged(object sender, EventArgs e)
        {
            PnlAuth.Visible = RdAuth.Checked;
            //if (RdAuth.Checked)
            //{
            //    grpServer.Height = PnlAuth.Height + 65;
            //}
            //else
            //    grpServer.Height = 65;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            var server = GetServer();
            if (MongoConnection.Logic.MongoGeneralLogic.TryToConnectToServer(server))
            {
                MessageBox.Show("Connection OK", "Connection Result", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection Failed", "Connection Result", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingImg.Visible = false;
            InputPnl.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (OnEditServer.HasValue)
                    Session.Settings.Servers[OnEditServer.Value] = GetServer();
                else
                    Session.Settings.Servers.Add(GetServer());
                Session.Settings.Save();
                Close();
            }
        }
    }
}
