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
    public partial class FrmCompareAndImport : Form
    {
        MDTCollection SourceCollection;
        MDTCollection TargetCollection;
        List<CompareResult> compareResult;
        public string Log { get; set; }

        public FrmCompareAndImport(MDTCollection SourceCollection)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.SourceCollection = SourceCollection;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Grv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Items From Grid");
                return;
            }
            foreach (DataGridViewRow row in Grv.SelectedRows)
            {
                var CompareResultItem = compareResult.FirstOrDefault(x => x.Item["_id"] == row.Cells[1].Value);
                if (CompareResultItem.CompareType == CompareResultType.New)
                {
                    try
                    {
                        //insert  
                        MongoGeneralLogic.InsertCollection(SourceCollection, CompareResultItem.Item);
                    }
                    catch (Exception)
                    {
                    }

                }
                else
                {
                    //update   
                    MongoGeneralLogic.UpdateCollection(CompareResultItem.Item["_id"].ToString(), CompareResultItem.Item, SourceCollection.Server.ConnectionString, SourceCollection.DatabaseName, SourceCollection.CollectionName);
                }

            }
            MessageBox.Show("Selected Rows Updated/Inserted To Collection");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Json files|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            var LocalServer = Session.Settings.Servers.FirstOrDefault(x => x.IsLocal);
            if (LocalServer != null)
            {
                TargetCollection = new MDTCollection()
                {
                    Server = LocalServer,
                    DatabaseName = "_tempMongoDb",
                    CollectionName = "_TempCollection" + Guid.NewGuid(),
                };
                if (RdJson.Checked)
                {
                    Log = MongoGeneralLogic.ImportFromJson(LocalServer, TargetCollection.DatabaseName,
                      txtFilePath.Text, TargetCollection.CollectionName, true);
                }
                if (TargetCollection != null)
                {
                    compareResult = MongoGeneralLogic.CompareCollections(
                              SourceCollection, TargetCollection, out TimeSpan ts);
                    Grv.DataSource = compareResult;

                    var dt = MongoGeneralLogic.ConvertToDataTable(compareResult.Select(x => x.Item).ToList());
                    Grv.DataSource = dt;
                    Grv.EditMode = DataGridViewEditMode.EditProgrammatically;
                    for (int i = 0; i < compareResult.Count; i++)
                    {
                        DataGridViewImageCell cell = Grv.Rows[i].Cells[0] as DataGridViewImageCell;
                        if (compareResult[i].CompareType == CompareResultType.New)
                            cell.Value = Properties.Resources.add_16x16;
                        else
                            cell.Value = Properties.Resources.edit_16x16;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Target Source To Be Compared");
                }

            }
            else
            {
                MessageBox.Show("No Local Server Setting Found");
            }

        }

        private void FrmCompareAndImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RdJson.Checked)
                MongoGeneralLogic.DropCollection(TargetCollection.Server.ConnectionString, TargetCollection.DatabaseName,
                    TargetCollection.CollectionName);
        }

        private void RdToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (RdJson.Checked)
            {
                PathPnl.Visible = true;
            }
            else
            {
                PathPnl.Visible = false;

            }
        }
    }
}
