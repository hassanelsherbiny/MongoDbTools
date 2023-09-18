using MongoConnection.Data;
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
    public partial class FrmSettings : Form
    {

        public FrmSettings()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ChkStartLocalServiceWithStartUp.Checked = Session.Settings.StartLocalServiceWithStartUp;
            txtMongoInstallationPath.Text = Session.Settings.MongoInstallationPath;
            txtLocalHostDataFilesPath.Text = Session.Settings.LocalHostDataFilesPath;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Session.Settings.StartLocalServiceWithStartUp = ChkStartLocalServiceWithStartUp.Checked;
            Session.Settings.MongoInstallationPath = txtMongoInstallationPath.Text;
            Session.Settings.LocalHostDataFilesPath = txtLocalHostDataFilesPath.Text;
            Session.Settings.Save();
            Close();
        }

        private void BtnConnections_Click(object sender, EventArgs e)
        {
            (new ConnectionsFrm()).ShowDialog();
        }
    }
}
