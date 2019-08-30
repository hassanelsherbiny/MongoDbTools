using MongoConnection.Data;
using MongoConnection.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class ImportFromJsonFrm : Form
    {
        List<string> SelectedFiles;
        MDTServer server;
        public ImportFromJsonFrm(MDTServer server)
        {
            InitializeComponent();
            this.server = server;
        }
        public ImportFromJsonFrm(string DbName, MDTServer server) : this(server)
        {
            this.TxtDbName.Text = DbName;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPath.Text))
            {
                LoadingImg.Visible = true;
                LoadingLbl.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("BackUp File Doesn't Exist");
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Json files|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = string.Join(",", ofd.FileNames.Select(x => Path.GetFileNameWithoutExtension(x)).ToList());
                SelectedFiles = ofd.FileNames.ToList();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MongoGeneralLogic.ImportFromJson(server, TxtDbName.Text, SelectedFiles, ChkDropIfExist.Checked);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show("Done");
            Close();
        }
    }
}
