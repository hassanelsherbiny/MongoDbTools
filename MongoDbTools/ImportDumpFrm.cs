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
        string ConnectionString;
        public ImportDumpFrm(string ConnectionString)
        {
            InitializeComponent();
            this.ConnectionString = ConnectionString;
        }
        public ImportDumpFrm(string DbName, string ConnectionString) : this(ConnectionString)
        {
            this.TxtDbName.Text = DbName;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(TxtPath.Text))
            {
                MongoGeneralLogic.ImportFromDump(ConnectionString, TxtDbName.Text, TxtPath.Text, ChkDropIfExist.Checked);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Done");
                Close();
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
    }
}
