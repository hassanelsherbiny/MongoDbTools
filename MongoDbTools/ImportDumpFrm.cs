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
    public partial class ImportDumpFrm : Form
    {
        MDTServer server;
        public ImportDumpFrm(MDTServer server)
        {
            InitializeComponent();
            this.server = server;
        }
        public ImportDumpFrm(string DbName, MDTServer server) : this(server)
        {
            this.TxtDbName.Text = DbName;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(TxtPath.Text))
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
            ofd.Filter = "MongoDb Tools BackUp file|*.mdt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = ofd.FileName;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MongoGeneralLogic.ImportFromDump(server, TxtDbName.Text, TxtPath.Text, ChkDropIfExist.Checked);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        { 
            DialogResult = DialogResult.OK;
            MessageBox.Show("Done");
            Close();
        }
    }
}
