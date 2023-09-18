using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoConnection.Logic;
using MongoConnection.Data;
using Alex75.JsonViewer.WindowsForm;
using MongoDbTools.UI;
using Newtonsoft.Json;

namespace MongoDbTools
{

    public partial class CollectionExplorerTab : UserControl
    {
        bool OnControlPressed, OnShiftPressed, OnAltPressed;
        int OnColumnIndex;
        int OnRowIndex;
        List<string> HiddenColumns = new List<string>();
        List<IDictionary<string, object>> Collection;

        public string ConnectionString, DbName, CollectionName;
        public MDTServer Server { get; set; }
        int CurrentPage = 0, ItemsPerPage, TotalPages;
        public CollectionExplorerTab(string ConnectionString, string DbName, string CollectionName)
        {
            InitializeComponent();
            this.DbName = DbName;
            this.ConnectionString = ConnectionString;
            this.CollectionName = CollectionName;
            long bytesSize;
            Collection = MongoGeneralLogic.GetCollection(ConnectionString, DbName, CollectionName, out bytesSize);
            CmbItemPerPage.SelectedIndex = 0;
            BindGrid();
            LblCollectionName.Text = DbName + "." + CollectionName;
            float bytesSizeF = bytesSize;
            if (bytesSizeF < 1000)
                LblSize.Text = Math.Round(bytesSizeF, 2) + " Bytes";
            else if (bytesSize < 1000 * 1000)
                LblSize.Text = Math.Round(bytesSizeF / 1000, 2) + " KB";
            else if (bytesSize < 1000 * 1000 * 1000)
                LblSize.Text = Math.Round(bytesSizeF / 1000000, 2) + " MB";
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            CurrentPage = TotalPages - 1;
            BindGrid();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentPage = 0;
            BindGrid();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            long bytesSize;
            Collection = MongoGeneralLogic.GetCollection(ConnectionString, DbName, CollectionName, out bytesSize);
            BindGrid();
            HiddenColumns.Clear();
        }

        private void Grv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var id = Grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            var item = Collection.FirstOrDefault(x => (x as Dictionary<string, object>)["_id"] == id);
            item[Grv.Columns[e.ColumnIndex].Name] = Grv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            MongoGeneralLogic.UpdateCollection(id, item, ConnectionString, DbName, CollectionName);
        }

        private void TxtFilterValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filter();
            }
        }
        void Filter()
        {
            long bytesSize;
            Collection = MongoGeneralLogic.GetCollection(ConnectionString, DbName, CollectionName, out bytesSize);
            if (DDFilterOperator.Text == "==")
                Collection = Collection.Where(x => x[TxtFilterCol.Text] != null && x.ContainsKey(TxtFilterCol.Text) &&
                x[TxtFilterCol.Text].ToString().ToLower() == TxtFilterValue.Text.ToLower()).ToList();
            if (DDFilterOperator.Text == "!=")
                Collection = Collection.Where(x => x[TxtFilterCol.Text] != null && x.ContainsKey(TxtFilterCol.Text) &&
                x[TxtFilterCol.Text].ToString().ToLower() != TxtFilterValue.Text.ToLower()).ToList();
            if (DDFilterOperator.Text == "Contains")
                Collection = Collection.Where(x => x[TxtFilterCol.Text] != null && x.ContainsKey(TxtFilterCol.Text) &&
                x[TxtFilterCol.Text].ToString().ToLower().Contains(TxtFilterValue.Text.ToLower())).ToList();
            if (DDFilterOperator.Text == "! Contains")
                Collection = Collection.Where(x => x[TxtFilterCol.Text] != null && x.ContainsKey(TxtFilterCol.Text) &&
                !x[TxtFilterCol.Text].ToString().ToLower().Contains(TxtFilterValue.Text.ToLower())).ToList();

            BindGrid();
        }

        private void Grv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FilterOrRemoveCol(e.ColumnIndex);
        }
        void FilterOrRemoveCol(int ColIndex)
        {
            if (OnControlPressed)
                TxtFilterCol.Text = Grv.Columns[ColIndex].Name;
            if (OnShiftPressed)
            {
                HideColumn(ColIndex);
            }
            if (OnAltPressed)
                ShowJsonViewer();
        }
        void HideColumn(int ColIndex)
        {
            HiddenColumns.Add(Grv.Columns[ColIndex].Name);
            Grv.Columns.RemoveAt(ColIndex);
        }
        private void Grv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                OnControlPressed = true;
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                OnShiftPressed = true;
            }
            if (e.KeyCode == Keys.Menu)
            {
                OnAltPressed = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (Grv.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete selected row(s)?", "Delete Row(s) Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int counter = 0;
                        int ToBeDeleted = Grv.SelectedRows.Count;
                        foreach (DataGridViewRow item in Grv.SelectedRows)
                        {
                            if (item.Cells["_id"].Value != null && MongoGeneralLogic.DeleteDocument(Server.ConnectionString, DbName, CollectionName, item.Cells["_id"].Value.ToString()))
                            {
                                Grv.Rows.Remove(item);
                                counter++;
                            }
                        }
                        MessageBox.Show(counter + "/" + ToBeDeleted + " Rows Deleted ");

                    }
                }
            }
        }

        private void Grv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilterOrRemoveCol(e.ColumnIndex);
        }

        private void Grv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilterOrRemoveCol(e.ColumnIndex);
        }

        private void Grv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OnColumnIndex = e.ColumnIndex;
                OnRowIndex = e.RowIndex;
                contextMenuStrip1.Show(Grv, Grv.PointToClient(Cursor.Position));
            }
        }

        private void ContextHide_Click(object sender, EventArgs e)
        {
            HideColumn(OnColumnIndex);
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void ContextFilter_Click(object sender, EventArgs e)
        {
            TxtFilterCol.Text = Grv.Columns[OnColumnIndex].Name;
        }

        private void btnJsonView_Click(object sender, EventArgs e)
        {
            ShowJsonViewer();
        }
        void ShowJsonViewer()
        {
            var json = JsonConvert.SerializeObject(Collection[OnRowIndex], Formatting.Indented);
            var jsonFrm = new JsonFrm(json);
            jsonFrm.ShowDialog();
        }
        private void Grv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                OnControlPressed = false;
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                OnShiftPressed = false;
            }
            if (e.KeyCode == Keys.Menu)
            {
                OnAltPressed = false;
            }
        }

        private void CmbItemPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsPerPage = int.Parse(CmbItemPerPage.Text);
            TotalPages = (int)Math.Ceiling(Collection.Count / (double)ItemsPerPage);
            CurrentPage = Math.Min(TotalPages - 1, CurrentPage);
            BindGrid();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                BindGrid();
            }

        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages - 1)
            {
                CurrentPage++;
                BindGrid();
            }
        }


        void BindGrid()
        {
            ItemsPerPage = int.Parse(CmbItemPerPage.Text);
            var dt = MongoGeneralLogic.ConvertToDataTable(Collection.Skip(CurrentPage * ItemsPerPage).Take(ItemsPerPage).ToList());
            TotalPages = (int)Math.Ceiling(Collection.Count / (double)ItemsPerPage);
            lblPages.Text = string.Format("{0} / {1}", CurrentPage + 1, TotalPages);
            LblCount.Text = Collection.Count.ToString();
            Grv.DataSource = dt;
            foreach (var col in HiddenColumns)
            {
                if (Grv.Columns[col] != null)
                {
                    Grv.Columns.Remove(Grv.Columns[col]);
                }
            }
        }
    }
}
