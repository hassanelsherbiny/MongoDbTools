using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoConnection.Data;
using MongoConnection.Logic;

namespace MongoDbTools
{
    public partial class ExportFrm : Form
    {
        string DbName;
        public string Log { get; set; }
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
            TimeSpan time;
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
                    ChkFormatJson.Checked, ChkArray.Checked, out log, out time);

                    Log = HandleExportLog(log, Collections.Count, time);
                    Close();
                }
            }
            else if (RdAnotherDb.Checked)
            {
                var exportTodbFrm = new ExportToDbFrm(server.ConnectionString, DbName, Collections);
                if (exportTodbFrm.ShowDialog() == DialogResult.OK)
                {
                    //Log = HandleExportLog(log, 1, time);
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
                    MongoGeneralLogic.ExportToDump(server, DbName, TxtMdtFilePath.Text, Collections, out log, out time);

                    //   Log = HandleExportLog(log, 1, time);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please Select Save Path");
                }

            }
        }
        string HandleExportLog(string Log, int ExpectedSuccessCount, TimeSpan Time)
        {
            string OutLog = "";
            int ExportedCollectionsCount = 0;
            long totalDocuments = 0;
            foreach (var line in Log.Split('\n').Select(x => x.Trim()))
            {
                //Ignore Empty Lines / Connected Line Output / progress output
                if (!(string.IsNullOrEmpty(line) || line.Contains("connected") || line.Contains("%")))
                {
                    //Handle Export Lines 
                    if (line.Contains("exported"))
                    {
                        int startIndex = line.IndexOf("exported");
                        OutLog += line.Substring(startIndex, line.Length - startIndex);
                        ExportedCollectionsCount++;
                        var CollectionCount = Regex.Match(line, @"\d+").Value;
                        totalDocuments += long.Parse(CollectionCount);
                    }
                    //handle error lines
                    else
                    {
                        OutLog += line;
                    }
                    OutLog += Environment.NewLine;
                }
            }
            if (ExportedCollectionsCount != ExpectedSuccessCount)
                MessageBox.Show("Some Collections Failed To Export Please Look in Log");
            else
            {
                string result = $"Export Done Successfully.\n{ExpectedSuccessCount} Collection Exported.\n{totalDocuments:0,0} Documents.\nOperation Took : {Time} Seconds.";
                MessageBox.Show(result, "Export Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return OutLog;
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
