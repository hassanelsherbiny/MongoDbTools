using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoConnection.Logic;

namespace MongoDbTools
{
    public partial class ExportFrm : Form
    {
        string ConnectionString, DbName;

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CollectionChk.Items.Count; i++)
            {
                if (CollectionChk.GetItemChecked(i) != ChkAll.Checked)
                {
                    CollectionChk.SetItemCheckState(i, ChkAll.Checked ? CheckState.Checked : CheckState.Unchecked);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string log = "";
            var Collections = new List<string>();
            for (int i = 0; i < CollectionChk.Items.Count; i++)
            {
                if (CollectionChk.GetItemChecked(i))
                {
                    Collections.Add(CollectionChk.Items[i].ToString());
                }
            }
            //TODO Check Save Path
            if (RdJson.Checked)
            {

                //TODO Check Mongo Path 
                string MongoPath = @"C:\Program Files\MongoDB\Server\3.4\bin\";
                MongoGeneralLogic.ExportToJson(ConnectionString, DbName, txtSavePath.Text, Collections, MongoPath,
                    ChkFormatJson.Checked, out log);
                Close();
            }
            else if (RdAnotherDb.Checked)
            {
                var exportTodbFrm = new ExportToDbFrm(ConnectionString, DbName, Collections);
                if (exportTodbFrm.ShowDialog() == DialogResult.OK)
                {
                    Close();
                }

            }
            else if (RdBackUpFile.Checked)
            {
                string MongoPath = @"C:\Program Files\MongoDB\Server\3.4\bin\";
                MongoGeneralLogic.ExportToDump(ConnectionString, DbName, TxtMdtFilePath.Text, Collections, MongoPath, out log);
                MessageBox.Show(log);
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                TxtMdtFilePath.Text = Sfd.FileName;
            }
        }
        private void ExportOptionChanged(object sender, EventArgs e)
        {
            PnlExportFile.Visible = RdBackUpFile.Checked;
            PathPnl.Visible = RdJson.Checked; 
        }
        public ExportFrm(string ConnectionString, string DbName)
        {
            InitializeComponent();
            this.ConnectionString = ConnectionString;
            this.DbName = DbName;
            this.Text += " - " + DbName;
            var collections = MongoGeneralLogic.GetDatabaseCollections(ConnectionString, DbName);
            foreach (var item in collections)
            {
                CollectionChk.Items.Add(item, true);
            }
            ChkAll.Checked = true;
        }
    }
}
