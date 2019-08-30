using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoConnection.Data;
using MongoConnection.Logic;

namespace MongoDbTools
{
    public partial class ExportFrm : Form
    {
        string DbName;
        MDTServer server;
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
                if (!string.IsNullOrEmpty(txtSavePath.Text))
                {
                    MongoGeneralLogic.ExportToJson(server.ConnectionString, DbName, txtSavePath.Text, Collections,
                    ChkFormatJson.Checked, ChkArray.Checked, out log);
                    log = string.IsNullOrEmpty(log) ? "Done" : "";
                    MessageBox.Show(log);
                    Close();
                }
            }
            else if (RdAnotherDb.Checked)
            {
                var exportTodbFrm = new ExportToDbFrm(server.ConnectionString, DbName, Collections);
                if (exportTodbFrm.ShowDialog() == DialogResult.OK)
                {
                    log = string.IsNullOrEmpty(log) ? "Done" : "";
                    MessageBox.Show(log);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please Select Save Location");
                }
            }
            else if (RdBackUpFile.Checked)
            {
                if (!string.IsNullOrEmpty(TxtMdtFilePath.Text))
                {
                    MongoGeneralLogic.ExportToDump(server, DbName, TxtMdtFilePath.Text, Collections, out log);
                    log = string.IsNullOrEmpty(log) ? "Done" : "";
                    MessageBox.Show(log);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please Select Save Path");
                }

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
        public ExportFrm(MDTServer server, string DbName, List<string> Collection)
        {
            InitializeComponent();
            this.server = server;
            this.DbName = DbName;
            this.Text += " - " + DbName;
            var collections = MongoGeneralLogic.GetDatabaseCollections(server.ConnectionString, DbName);
            foreach (var item in collections)
            {
                bool ChekItem = !Collection.Any() || Collection.Contains(item);
                if (Collection.Any())
                {
                    CollectionChk.Items.Add(item, ChekItem);
                }
                else
                {
                    CollectionChk.Items.Add(item, true);
                }
            }
            ChkAll.Checked = !Collection.Any();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fwd = new FolderBrowserDialog();
            if (fwd.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = fwd.SelectedPath;
            }
        }
    }
}
