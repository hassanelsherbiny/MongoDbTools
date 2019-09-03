namespace MongoDbTools
{
    partial class FrmMigrations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMigrations));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrvMigrations = new System.Windows.Forms.DataGridView();
            this.IconCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMigrations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Options";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel1.Size = new System.Drawing.Size(794, 63);
            this.panel1.TabIndex = 19;
            // 
            // BtnExport
            // 
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExport.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExport.Location = new System.Drawing.Point(5, 10);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(119, 41);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.Text = "New Migration";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(695, 10);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 41);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GrvMigrations
            // 
            this.GrvMigrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvMigrations.BackgroundColor = System.Drawing.Color.White;
            this.GrvMigrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvMigrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconCol});
            this.GrvMigrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrvMigrations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrvMigrations.Location = new System.Drawing.Point(0, 82);
            this.GrvMigrations.Name = "GrvMigrations";
            this.GrvMigrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrvMigrations.Size = new System.Drawing.Size(800, 368);
            this.GrvMigrations.TabIndex = 9;
            this.GrvMigrations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvMigrations_CellContentClick);
            this.GrvMigrations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrvMigrations_CellMouseDoubleClick);
            // 
            // IconCol
            // 
            this.IconCol.FillWeight = 20F;
            this.IconCol.HeaderText = "";
            this.IconCol.Image = global::MongoDbTools.Properties.Resources.delete_16x16;
            this.IconCol.Name = "IconCol";
            // 
            // FrmMigrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvMigrations);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMigrations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Migrations";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvMigrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridView GrvMigrations;
        private System.Windows.Forms.DataGridViewImageColumn IconCol;
    }
}