using MongoConnection.Data;
using MongoConnection.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class FrmMigration : Form
    {
        public MDTMigratorFile MigrationOptions { get; set; }
        public FrmMigration(MDTMigratorFile MigrationOptions)
        {
            InitializeComponent();

            if (MigrationOptions != null)
            {
                this.MigrationOptions = DeepCopy(MigrationOptions);
                if (MigrationOptions.SourceServer != null)
                    TxtSource.Text = MigrationOptions.SourceServer.ToString();
                TxtSourceDb.Text = MigrationOptions.SourceDb;
                if (MigrationOptions.DestinationServer != null)
                    TxtDest.Text = MigrationOptions.DestinationServer.ToString();
                if (MigrationOptions.DestinationDb != null)
                    TxtDestDb.Text = MigrationOptions.DestinationDb.ToString();
                else
                    TxtDestDb.Text = TxtSourceDb.Text;
                TxtMigrationName.Text = MigrationOptions.Name;
                GetCollectionFromSource();
            }
            else
                this.MigrationOptions = new MDTMigratorFile();
        }
        void GetCollectionFromSource()
        {
            if (MigrationOptions.SourceServer != null)
            {
                var collections = MongoGeneralLogic.GetDatabaseCollections(MigrationOptions.SourceServer.ConnectionString, MigrationOptions.SourceDb);
                foreach (var item in collections)
                {
                    bool ChekItem = !MigrationOptions.Collections.Any() || MigrationOptions.Collections.Contains(item);
                    if (MigrationOptions.Collections.Any())
                    {
                        CollectionChk.Items.Add(item, ChekItem);
                    }
                    else
                    {
                        CollectionChk.Items.Add(item, true);
                    }
                }
            }
        }
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

        private void BtnMigrate_Click(object sender, EventArgs e)
        {
            if (ValidateInputes())
                Migrate();
        }

        private void SaveMigration()
        {
            MigrationOptions.Collections.Clear();
            for (int i = 0; i < CollectionChk.Items.Count; i++)
            {
                if (CollectionChk.GetItemChecked(i))
                {
                    MigrationOptions.Collections.Add(CollectionChk.Items[i].ToString());
                }
            }
            if (ValidateInputes())
            {
                //Save Migration File
              
                if (string.IsNullOrEmpty(MigrationOptions.Id))
                {
                    MigrationOptions.GenerateId();
                    Session.Migrators.Add(MigrationOptions);
                }
                else
                {
                    var _MigrationOptions = Session.Migrators.FirstOrDefault(x => x.Id == MigrationOptions.Id);
                    _MigrationOptions = MigrationOptions;
                }

                Session.SaveMigrators();
            }

        }

        private bool ValidateInputes()
        {
            #region Validation

            if (string.IsNullOrEmpty(TxtDestDb.Text))
            {
                MessageBox.Show("Please Enter Destination Db Name");
                return false;
            }
            if (string.IsNullOrEmpty(TxtSourceDb.Text))
            {
                MessageBox.Show("Please Enter Source Db Name");
                return false;
            }
            if (MigrationOptions.DestinationServer == null)
            {
                MessageBox.Show("Please Select Destination");
                return false;
            }
            if (MigrationOptions.SourceServer == null)
            {
                MessageBox.Show("Please Select Source");
                return false;
            } 
            #endregion
            MigrationOptions.Name = TxtMigrationName.Text;
            MigrationOptions.DestinationDb = TxtDestDb.Text;
            MigrationOptions.SourceDb = TxtSourceDb.Text;
            return true;
        }

        private void BtnSelectDestination_Click(object sender, EventArgs e)
        {
            ConnectionsFrm frm = new ConnectionsFrm();
            frm.AsSelection = true;
            frm.ShowDialog();
            if (frm.SelectedServer != null)
            {
                MigrationOptions.DestinationServer = frm.SelectedServer;
                TxtDest.Text = frm.SelectedServer.ToString();
            }
        }

        private void BtnSelectSource_Click(object sender, EventArgs e)
        {
            ConnectionsFrm frm = new ConnectionsFrm();
            frm.AsSelection = true;
            frm.ShowDialog(); if (frm.SelectedServer != null)
            {
                MigrationOptions.SourceServer = frm.SelectedServer;
                TxtSource.Text = frm.SelectedServer.ToString();
                GetCollectionFromSource();
            }
        }

        private void TxtSourceDb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MigrationOptions.SourceDb = TxtSourceDb.Text;
                GetCollectionFromSource();
            }
        }

        private void CollectionChk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CollectionChk.SelectedIndex;
            var chkState = CollectionChk.GetItemChecked(i) ? CheckState.Unchecked : CheckState.Checked;
            CollectionChk.SetItemCheckState(i, chkState);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveMigration();
            MessageBox.Show("Migration Saved");
        }

        private void BtnSaveAndMigrate_Click(object sender, EventArgs e)
        {
            SaveMigration();
            //Start Migration 
            Migrate();

        }
        void Migrate()
        {
            MigrationOptions.Collections.Clear();
            for (int i = 0; i < CollectionChk.Items.Count; i++)
            {
                if (CollectionChk.GetItemChecked(i))
                {
                    MigrationOptions.Collections.Add(CollectionChk.Items[i].ToString());
                }
            }
            if (!MigrationOptions.Collections.Any())
            {
                MessageBox.Show("Please Select Collections To Be Migrated");
                return;
            }
            string log = "";
            var exportPath = MongoGeneralLogic.ExportToJson(MigrationOptions.SourceServer.ConnectionString,
                MigrationOptions.SourceDb, "", MigrationOptions.Collections, true, false, out log, true);


            MongoGeneralLogic.ImportFromJson(MigrationOptions.DestinationServer, MigrationOptions.DestinationDb, Directory.GetFiles(exportPath).ToList(), true);
            try
            {
                Directory.Delete(exportPath, true);
                MessageBox.Show("Migration DONE");
            }
            catch
            {
                MessageBox.Show("Migration ERROR");
            }

        }
        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Context = new StreamingContext(StreamingContextStates.Clone);
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }

}
