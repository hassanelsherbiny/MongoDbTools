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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class ImportFromJsonFrm : Form
    {
        List<string> SelectedFiles;
        public string Log { get; set; }
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
        TimeSpan time;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Log = MongoGeneralLogic.ImportFromJson(server, TxtDbName.Text, SelectedFiles, ChkDropIfExist.Checked, out time);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Log = HandleImportLog(Log, time);
            Close();
        }

        string HandleImportLog(string Log, TimeSpan Time)
        {
            string OutLog = "";
            int ImportedCollectionsCount = 0;
            long totalDocuments = 0;
            foreach (var line in Log.Split('\n').Select(x => x.Trim()))
            {
                //Ignore Empty Lines / Connected Line Output / progress output
                if (!(string.IsNullOrEmpty(line) || line.Contains("connected") || line.Contains("%")))
                {
                    //Handle imported Lines 
                    if (line.Contains("imported"))
                    {
                        int startIndex = line.IndexOf("imported");
                        OutLog += line.Substring(startIndex, line.Length - startIndex);
                        ImportedCollectionsCount++;
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

            string result = $"Import Done Successfully.\n{ImportedCollectionsCount} Collection Imported.\n{totalDocuments:0,0} Documents.\nOperation Took : {Time} Seconds.";
            MessageBox.Show(result, "Import Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return OutLog;
        }
    }
}
