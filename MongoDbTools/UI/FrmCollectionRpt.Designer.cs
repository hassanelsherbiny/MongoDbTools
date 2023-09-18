namespace MongoDbTools
{
    partial class FrmCollectionRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCollectionRpt));
            this.label1 = new System.Windows.Forms.Label();
            this.GrvReport = new System.Windows.Forms.DataGridView();
            this.IconCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // GrvReport
            // 
            this.GrvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvReport.BackgroundColor = System.Drawing.Color.White;
            this.GrvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconCol});
            this.GrvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrvReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrvReport.Location = new System.Drawing.Point(0, 25);
            this.GrvReport.Name = "GrvReport";
            this.GrvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrvReport.Size = new System.Drawing.Size(948, 483);
            this.GrvReport.TabIndex = 10;
            // 
            // IconCol
            // 
            this.IconCol.FillWeight = 20F;
            this.IconCol.HeaderText = "";
            this.IconCol.Image = global::MongoDbTools.Properties.Resources.unmergecells_16x16;
            this.IconCol.Name = "IconCol";
            // 
            // FrmCollectionRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.GrvReport);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCollectionRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Db Collection Report";
            ((System.ComponentModel.ISupportInitialize)(this.GrvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrvReport;
        private System.Windows.Forms.DataGridViewImageColumn IconCol;
    }
}