using MongoConnection.Data;
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
    public partial class FrmMigrations : Form
    {
        public MDTMigratorFile SelectedMigrator { get; set; }
        public FrmMigrations()
        {
            InitializeComponent();
            BindMigrationsGrid();
        }


        private void BtnExport_Click(object sender, EventArgs e)
        {
            FrmMigration frm = new FrmMigration(SelectedMigrator);
            frm.ShowDialog();
            BindMigrationsGrid();
        }
        void BindMigrationsGrid()
        {
            GrvMigrations.DataSource = Session.Migrators.Select(x => new
            {
                x.Name,
                x.SourceServer,
                x.SourceDb,
                x.DestinationServer,
                x.DestinationDb
            }).ToList();
        }

        private void GrvMigrations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedMigrator = Session.Migrators[GrvMigrations.SelectedRows[0].Index];
            BtnExport_Click(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GrvMigrations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Delete Confirmation", "are you sure you want to delete this migration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Session.Migrators.RemoveAt(e.RowIndex);
                    Session.SaveMigrators();
                    BindMigrationsGrid();
                }
            }
        }
    }
}
