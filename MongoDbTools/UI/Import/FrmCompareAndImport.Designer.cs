namespace MongoDbTools
{
    partial class FrmCompareAndImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompareAndImport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.PathPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RdJson = new System.Windows.Forms.RadioButton();
            this.RdAnotherDb = new System.Windows.Forms.RadioButton();
            this.Grv = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PathPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadingImg);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 39);
            this.panel1.TabIndex = 2;
            // 
            // LoadingImg
            // 
            this.LoadingImg.Image = global::MongoDbTools.Properties.Resources.ConnectingLoader;
            this.LoadingImg.Location = new System.Drawing.Point(12, 3);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(140, 34);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingImg.TabIndex = 12;
            this.LoadingImg.TabStop = false;
            this.LoadingImg.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Image = global::MongoDbTools.Properties.Resources.cancel_32x32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(818, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 32);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Image = global::MongoDbTools.Properties.Resources.apply_32x32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(604, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(208, 32);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save Selected To First Collection";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(263, 15);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(29, 23);
            this.BtnBrowse.TabIndex = 5;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(3, 17);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(254, 20);
            this.txtFilePath.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnCompare);
            this.splitContainer1.Panel1.Controls.Add(this.PathPnl);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grv);
            this.splitContainer1.Size = new System.Drawing.Size(915, 438);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 6;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCompare.Image = global::MongoDbTools.Properties.Resources.group2_32x32;
            this.BtnCompare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompare.Location = new System.Drawing.Point(510, 6);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(111, 37);
            this.BtnCompare.TabIndex = 21;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // PathPnl
            // 
            this.PathPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPnl.Controls.Add(this.label2);
            this.PathPnl.Controls.Add(this.BtnBrowse);
            this.PathPnl.Controls.Add(this.txtFilePath);
            this.PathPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PathPnl.Location = new System.Drawing.Point(200, 0);
            this.PathPnl.Name = "PathPnl";
            this.PathPnl.Size = new System.Drawing.Size(304, 46);
            this.PathPnl.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Json File Path";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RdJson);
            this.flowLayoutPanel1.Controls.Add(this.RdAnotherDb);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 46);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // RdJson
            // 
            this.RdJson.AutoSize = true;
            this.RdJson.Checked = true;
            this.RdJson.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdJson.Location = new System.Drawing.Point(3, 3);
            this.RdJson.Name = "RdJson";
            this.RdJson.Size = new System.Drawing.Size(92, 17);
            this.RdJson.TabIndex = 4;
            this.RdJson.TabStop = true;
            this.RdJson.Text = "From Json File";
            this.RdJson.UseVisualStyleBackColor = true;
            this.RdJson.CheckedChanged += new System.EventHandler(this.RdToggle_CheckedChanged);
            // 
            // RdAnotherDb
            // 
            this.RdAnotherDb.AutoSize = true;
            this.RdAnotherDb.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdAnotherDb.Location = new System.Drawing.Point(3, 26);
            this.RdAnotherDb.Name = "RdAnotherDb";
            this.RdAnotherDb.Size = new System.Drawing.Size(137, 17);
            this.RdAnotherDb.TabIndex = 6;
            this.RdAnotherDb.Text = "From Another Database";
            this.RdAnotherDb.UseVisualStyleBackColor = true;
            this.RdAnotherDb.Visible = false;
            // 
            // Grv
            // 
            this.Grv.AllowUserToAddRows = false;
            this.Grv.AllowUserToDeleteRows = false;
            this.Grv.AllowUserToOrderColumns = true;
            this.Grv.BackgroundColor = System.Drawing.Color.White;
            this.Grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img});
            this.Grv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grv.GridColor = System.Drawing.Color.Black;
            this.Grv.Location = new System.Drawing.Point(0, 0);
            this.Grv.Name = "Grv";
            this.Grv.ReadOnly = true;
            this.Grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grv.ShowEditingIcon = false;
            this.Grv.Size = new System.Drawing.Size(915, 388);
            this.Grv.TabIndex = 3;
            // 
            // Img
            // 
            this.Img.FillWeight = 30F;
            this.Img.Frozen = true;
            this.Img.HeaderText = "";
            this.Img.Image = global::MongoDbTools.Properties.Resources.edit_16x16;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Img.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MongoDbTools.Properties.Resources.database_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 757;
            // 
            // FrmCompareAndImport
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 477);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompareAndImport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compare And Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompareAndImport_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PathPnl.ResumeLayout(false);
            this.PathPnl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox LoadingImg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Grv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RdJson;
        private System.Windows.Forms.RadioButton RdAnotherDb;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.Panel PathPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Img;
    }
}