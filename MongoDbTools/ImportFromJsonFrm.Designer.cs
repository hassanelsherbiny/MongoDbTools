namespace MongoDbTools
{
    partial class ImportFromJsonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFromJsonFrm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSelectFiles = new System.Windows.Forms.Button();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.BtnImport = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FilesChk = new System.Windows.Forms.CheckedListBox();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelectFiles
            // 
            this.BtnSelectFiles.Location = new System.Drawing.Point(12, 9);
            this.BtnSelectFiles.Name = "BtnSelectFiles";
            this.BtnSelectFiles.Size = new System.Drawing.Size(160, 25);
            this.BtnSelectFiles.TabIndex = 5;
            this.BtnSelectFiles.Text = "Select Files";
            this.toolTip1.SetToolTip(this.BtnSelectFiles, "Browse");
            this.BtnSelectFiles.UseVisualStyleBackColor = true;
            this.BtnSelectFiles.Click += new System.EventHandler(this.BtnSelectFiles_Click);
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChkAll.Location = new System.Drawing.Point(0, 35);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ChkAll.Size = new System.Drawing.Size(376, 14);
            this.ChkAll.TabIndex = 7;
            this.toolTip1.SetToolTip(this.ChkAll, "Selecet / Deselect All");
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(213, 9);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(160, 25);
            this.BtnImport.TabIndex = 8;
            this.BtnImport.Text = "Import";
            this.toolTip1.SetToolTip(this.BtnImport, "Browse");
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.BtnImport);
            this.splitContainer1.Panel1.Controls.Add(this.ChkAll);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSelectFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FilesChk);
            this.splitContainer1.Size = new System.Drawing.Size(376, 322);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 0;
            // 
            // FilesChk
            // 
            this.FilesChk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesChk.FormattingEnabled = true;
            this.FilesChk.Location = new System.Drawing.Point(0, 0);
            this.FilesChk.Name = "FilesChk";
            this.FilesChk.Size = new System.Drawing.Size(376, 269);
            this.FilesChk.TabIndex = 8;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Json Files";
            this.Ofd.Filter = "*.Json|*.json|ALL|*.*";
            this.Ofd.Multiselect = true;
            // 
            // ImportFromJsonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 322);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportFromJsonFrm";
            this.Text = "Import From Json";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnSelectFiles;
        private System.Windows.Forms.CheckedListBox FilesChk;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.Button BtnImport;
    }
}