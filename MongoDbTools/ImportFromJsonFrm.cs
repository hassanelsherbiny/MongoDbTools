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
        string ServerConnection, DbName;
        public ImportFromJsonFrm(string ServerConnection, string DbName)
        {
            InitializeComponent();
            this.ServerConnection = ServerConnection;
            this.DbName = DbName;
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FilesChk.Items.Count; i++)
            {
                if (FilesChk.GetItemChecked(i) != ChkAll.Checked)
                {
                    FilesChk.SetItemCheckState(i, ChkAll.Checked ? CheckState.Checked : CheckState.Unchecked);
                }
            }
        }

        private void BtnSelectFiles_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                FilesChk.Items.Clear();
                FilesChk.DisplayMember = "Text";
                FilesChk.ValueMember = "Value";

                foreach (var file in Ofd.FileNames)
                {
                    FilesChk.Items.Add(new { Text = Path.GetFileNameWithoutExtension(file), Value = file });
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var SelectedFiles = new List<string>();
            for (int i = 0; i < FilesChk.Items.Count; i++)
            {
                if (FilesChk.GetItemChecked(i))
                {
                    SelectedFiles.Add(((dynamic)FilesChk.Items[i]).Value);
                }
            }
            if (SelectedFiles.Any())
            {
                MongoGeneralLogic.Import(DbName, SelectedFiles, ServerConnection);
            }
            else
            {
                MessageBox.Show("Please Select Files");
            }

        }
    }
}
