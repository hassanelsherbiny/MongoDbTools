namespace MongoDbTools
{
    partial class FrmMigration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMigration));
            this.Sfd = new System.Windows.Forms.SaveFileDialog();
            this.CollectionChk = new System.Windows.Forms.CheckedListBox();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMigrationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PathPnl = new System.Windows.Forms.Panel();
            this.TxtSourceDb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSelectSource = new System.Windows.Forms.Button();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlExportFile = new System.Windows.Forms.Panel();
            this.TxtDestDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSelectDestination = new System.Windows.Forms.Button();
            this.TxtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnMigrate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSaveAndMigrate = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PathPnl.SuspendLayout();
            this.PnlExportFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sfd
            // 
            this.Sfd.Filter = "Mongo Db Tools File|*.MDT";
            // 
            // CollectionChk
            // 
            this.CollectionChk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionChk.FormattingEnabled = true;
            this.CollectionChk.Location = new System.Drawing.Point(0, 152);
            this.CollectionChk.MultiColumn = true;
            this.CollectionChk.Name = "CollectionChk";
            this.CollectionChk.Size = new System.Drawing.Size(1083, 298);
            this.CollectionChk.TabIndex = 10;
            this.CollectionChk.SelectedIndexChanged += new System.EventHandler(this.CollectionChk_SelectedIndexChanged);
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChkAll.Location = new System.Drawing.Point(0, 138);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ChkAll.Size = new System.Drawing.Size(1083, 14);
            this.ChkAll.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ChkAll, "Selecet / Deselect All");
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.PathPnl);
            this.flowLayoutPanel2.Controls.Add(this.PnlExportFile);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1077, 119);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtMigrationName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 93);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtMigrationName
            // 
            this.TxtMigrationName.Location = new System.Drawing.Point(6, 33);
            this.TxtMigrationName.Name = "TxtMigrationName";
            this.TxtMigrationName.Size = new System.Drawing.Size(225, 20);
            this.TxtMigrationName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Migration Name";
            // 
            // PathPnl
            // 
            this.PathPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPnl.Controls.Add(this.TxtSourceDb);
            this.PathPnl.Controls.Add(this.label5);
            this.PathPnl.Controls.Add(this.BtnSelectSource);
            this.PathPnl.Controls.Add(this.TxtSource);
            this.PathPnl.Controls.Add(this.label1);
            this.PathPnl.Location = new System.Drawing.Point(245, 3);
            this.PathPnl.Name = "PathPnl";
            this.PathPnl.Size = new System.Drawing.Size(248, 93);
            this.PathPnl.TabIndex = 15;
            // 
            // TxtSourceDb
            // 
            this.TxtSourceDb.Location = new System.Drawing.Point(6, 56);
            this.TxtSourceDb.Name = "TxtSourceDb";
            this.TxtSourceDb.Size = new System.Drawing.Size(225, 20);
            this.TxtSourceDb.TabIndex = 4;
            this.TxtSourceDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSourceDb_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DB";
            // 
            // BtnSelectSource
            // 
            this.BtnSelectSource.Location = new System.Drawing.Point(213, 14);
            this.BtnSelectSource.Name = "BtnSelectSource";
            this.BtnSelectSource.Size = new System.Drawing.Size(29, 23);
            this.BtnSelectSource.TabIndex = 2;
            this.BtnSelectSource.Text = "...";
            this.BtnSelectSource.UseVisualStyleBackColor = true;
            this.BtnSelectSource.Click += new System.EventHandler(this.BtnSelectSource_Click);
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(6, 17);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.ReadOnly = true;
            this.TxtSource.Size = new System.Drawing.Size(201, 20);
            this.TxtSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // PnlExportFile
            // 
            this.PnlExportFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlExportFile.Controls.Add(this.TxtDestDb);
            this.PnlExportFile.Controls.Add(this.label4);
            this.PnlExportFile.Controls.Add(this.BtnSelectDestination);
            this.PnlExportFile.Controls.Add(this.TxtDest);
            this.PnlExportFile.Controls.Add(this.label2);
            this.PnlExportFile.Location = new System.Drawing.Point(499, 3);
            this.PnlExportFile.Name = "PnlExportFile";
            this.PnlExportFile.Size = new System.Drawing.Size(252, 93);
            this.PnlExportFile.TabIndex = 17;
            // 
            // TxtDestDb
            // 
            this.TxtDestDb.Location = new System.Drawing.Point(6, 56);
            this.TxtDestDb.Name = "TxtDestDb";
            this.TxtDestDb.Size = new System.Drawing.Size(225, 20);
            this.TxtDestDb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DB";
            // 
            // BtnSelectDestination
            // 
            this.BtnSelectDestination.Location = new System.Drawing.Point(213, 14);
            this.BtnSelectDestination.Name = "BtnSelectDestination";
            this.BtnSelectDestination.Size = new System.Drawing.Size(29, 23);
            this.BtnSelectDestination.TabIndex = 2;
            this.BtnSelectDestination.Text = "...";
            this.BtnSelectDestination.UseVisualStyleBackColor = true;
            this.BtnSelectDestination.Click += new System.EventHandler(this.BtnSelectDestination_Click);
            // 
            // TxtDest
            // 
            this.TxtDest.Location = new System.Drawing.Point(6, 17);
            this.TxtDest.Name = "TxtDest";
            this.TxtDest.ReadOnly = true;
            this.TxtDest.Size = new System.Drawing.Size(201, 20);
            this.TxtDest.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnSaveAndMigrate);
            this.panel1.Controls.Add(this.BtnMigrate);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Location = new System.Drawing.Point(757, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 93);
            this.panel1.TabIndex = 18;
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Image = global::MongoDbTools.Properties.Resources.save_16x16;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(142, 59);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(92, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnMigrate
            // 
            this.BtnMigrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMigrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMigrate.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnMigrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMigrate.Location = new System.Drawing.Point(12, 30);
            this.BtnMigrate.Name = "BtnMigrate";
            this.BtnMigrate.Size = new System.Drawing.Size(122, 23);
            this.BtnMigrate.TabIndex = 10;
            this.BtnMigrate.Text = "Migrate";
            this.BtnMigrate.UseVisualStyleBackColor = true;
            this.BtnMigrate.Click += new System.EventHandler(this.BtnMigrate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(142, 30);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Migration ";
            // 
            // BtnSaveAndMigrate
            // 
            this.BtnSaveAndMigrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveAndMigrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveAndMigrate.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnSaveAndMigrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveAndMigrate.Location = new System.Drawing.Point(12, 59);
            this.BtnSaveAndMigrate.Name = "BtnSaveAndMigrate";
            this.BtnSaveAndMigrate.Size = new System.Drawing.Size(122, 23);
            this.BtnSaveAndMigrate.TabIndex = 10;
            this.BtnSaveAndMigrate.Text = "Save && Migrate";
            this.BtnSaveAndMigrate.UseVisualStyleBackColor = true;
            this.BtnSaveAndMigrate.Click += new System.EventHandler(this.BtnSaveAndMigrate_Click);
            // 
            // FrmMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.CollectionChk);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMigration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apply Migration";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PathPnl.ResumeLayout(false);
            this.PathPnl.PerformLayout();
            this.PnlExportFile.ResumeLayout(false);
            this.PnlExportFile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog Sfd;
        private System.Windows.Forms.CheckedListBox CollectionChk;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMigrate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PathPnl;
        private System.Windows.Forms.Button BtnSelectSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlExportFile;
        private System.Windows.Forms.Button BtnSelectDestination;
        private System.Windows.Forms.TextBox TxtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMigrationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDestDb;
        private System.Windows.Forms.TextBox TxtSourceDb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSaveAndMigrate;
    }
}