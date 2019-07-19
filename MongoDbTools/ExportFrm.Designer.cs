namespace MongoDbTools
{
    partial class ExportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PnlExportFile = new System.Windows.Forms.Panel();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.TxtMdtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PathPnl = new System.Windows.Forms.Panel();
            this.ChkFormatJson = new System.Windows.Forms.CheckBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RdAnotherDb = new System.Windows.Forms.RadioButton();
            this.RdJson = new System.Windows.Forms.RadioButton();
            this.RdBackUpFile = new System.Windows.Forms.RadioButton();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.CollectionChk = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.PnlExportFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PathPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PnlExportFile);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.PathPnl);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Options";
            // 
            // PnlExportFile
            // 
            this.PnlExportFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlExportFile.Controls.Add(this.BtnSaveFile);
            this.PnlExportFile.Controls.Add(this.TxtMdtFilePath);
            this.PnlExportFile.Controls.Add(this.label2);
            this.PnlExportFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlExportFile.Location = new System.Drawing.Point(704, 16);
            this.PnlExportFile.Name = "PnlExportFile";
            this.PnlExportFile.Size = new System.Drawing.Size(304, 78);
            this.PnlExportFile.TabIndex = 17;
            this.PnlExportFile.Visible = false;
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.Location = new System.Drawing.Point(266, 14);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(29, 23);
            this.BtnSaveFile.TabIndex = 2;
            this.BtnSaveFile.Text = "...";
            this.BtnSaveFile.UseVisualStyleBackColor = true;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // TxtMdtFilePath
            // 
            this.TxtMdtFilePath.Location = new System.Drawing.Point(6, 17);
            this.TxtMdtFilePath.Name = "TxtMdtFilePath";
            this.TxtMdtFilePath.Size = new System.Drawing.Size(254, 20);
            this.TxtMdtFilePath.TabIndex = 1;
            this.TxtMdtFilePath.Text = "C:\\Users\\PRinCe Hassan\\Desktop\\xx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Save Path";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(507, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 78);
            this.panel1.TabIndex = 16;
            // 
            // BtnExport
            // 
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExport.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExport.Location = new System.Drawing.Point(5, 15);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(84, 23);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(95, 15);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PathPnl
            // 
            this.PathPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPnl.Controls.Add(this.ChkFormatJson);
            this.PathPnl.Controls.Add(this.BtnBrowse);
            this.PathPnl.Controls.Add(this.txtSavePath);
            this.PathPnl.Controls.Add(this.label1);
            this.PathPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PathPnl.Location = new System.Drawing.Point(203, 16);
            this.PathPnl.Name = "PathPnl";
            this.PathPnl.Size = new System.Drawing.Size(304, 78);
            this.PathPnl.TabIndex = 15;
            this.PathPnl.Visible = false;
            // 
            // ChkFormatJson
            // 
            this.ChkFormatJson.AutoSize = true;
            this.ChkFormatJson.Checked = true;
            this.ChkFormatJson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFormatJson.Location = new System.Drawing.Point(6, 44);
            this.ChkFormatJson.Name = "ChkFormatJson";
            this.ChkFormatJson.Size = new System.Drawing.Size(83, 17);
            this.ChkFormatJson.TabIndex = 3;
            this.ChkFormatJson.Text = "Format Json";
            this.ChkFormatJson.UseVisualStyleBackColor = true;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(266, 14);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(29, 23);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(6, 17);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(254, 20);
            this.txtSavePath.TabIndex = 1;
            this.txtSavePath.Text = "C:\\Users\\PRinCe Hassan\\Desktop\\xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Path";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RdAnotherDb);
            this.flowLayoutPanel1.Controls.Add(this.RdJson);
            this.flowLayoutPanel1.Controls.Add(this.RdBackUpFile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 78);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // RdAnotherDb
            // 
            this.RdAnotherDb.AutoSize = true;
            this.RdAnotherDb.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdAnotherDb.Location = new System.Drawing.Point(3, 3);
            this.RdAnotherDb.Name = "RdAnotherDb";
            this.RdAnotherDb.Size = new System.Drawing.Size(128, 17);
            this.RdAnotherDb.TabIndex = 5;
            this.RdAnotherDb.Text = "Export To Another Db";
            this.RdAnotherDb.UseVisualStyleBackColor = true;
            this.RdAnotherDb.CheckedChanged += new System.EventHandler(this.ExportOptionChanged);
            // 
            // RdJson
            // 
            this.RdJson.AutoSize = true;
            this.RdJson.Checked = true;
            this.RdJson.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdJson.Location = new System.Drawing.Point(3, 26);
            this.RdJson.Name = "RdJson";
            this.RdJson.Size = new System.Drawing.Size(96, 17);
            this.RdJson.TabIndex = 4;
            this.RdJson.TabStop = true;
            this.RdJson.Text = "Export To Json";
            this.RdJson.UseVisualStyleBackColor = true;
            this.RdJson.CheckedChanged += new System.EventHandler(this.ExportOptionChanged);
            // 
            // RdBackUpFile
            // 
            this.RdBackUpFile.AutoSize = true;
            this.RdBackUpFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdBackUpFile.Location = new System.Drawing.Point(3, 49);
            this.RdBackUpFile.Name = "RdBackUpFile";
            this.RdBackUpFile.Size = new System.Drawing.Size(132, 17);
            this.RdBackUpFile.TabIndex = 3;
            this.RdBackUpFile.Text = "Export To BackUp File";
            this.RdBackUpFile.UseVisualStyleBackColor = true;
            this.RdBackUpFile.CheckedChanged += new System.EventHandler(this.ExportOptionChanged);
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChkAll.Location = new System.Drawing.Point(0, 97);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ChkAll.Size = new System.Drawing.Size(992, 14);
            this.ChkAll.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ChkAll, "Selecet / Deselect All");
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // CollectionChk
            // 
            this.CollectionChk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionChk.FormattingEnabled = true;
            this.CollectionChk.Location = new System.Drawing.Point(0, 111);
            this.CollectionChk.Name = "CollectionChk";
            this.CollectionChk.Size = new System.Drawing.Size(992, 339);
            this.CollectionChk.TabIndex = 7;
            // 
            // Sfd
            // 
            this.Sfd.Filter = "Mongo Db Tools File|*.MDT";
            // 
            // ExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.CollectionChk);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export";
            this.groupBox1.ResumeLayout(false);
            this.PnlExportFile.ResumeLayout(false);
            this.PnlExportFile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PathPnl.ResumeLayout(false);
            this.PathPnl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.CheckedListBox CollectionChk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PathPnl;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RdAnotherDb;
        private System.Windows.Forms.RadioButton RdJson;
        private System.Windows.Forms.RadioButton RdBackUpFile;
        private System.Windows.Forms.CheckBox ChkFormatJson;
        private System.Windows.Forms.Panel PnlExportFile;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.TextBox TxtMdtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog Sfd;
    }
}