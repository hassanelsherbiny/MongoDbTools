namespace MongoDbTools
{
    partial class ImportDumpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDumpFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TxtDbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.ChkDropIfExist = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkDropIfExist);
            this.panel1.Controls.Add(this.BtnImport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDbName);
            this.panel1.Controls.Add(this.BtnSelectFile);
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BackUp File Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPath
            // 
            this.TxtPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtPath.Location = new System.Drawing.Point(0, 13);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(229, 20);
            this.TxtPath.TabIndex = 1;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(230, 12);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(32, 23);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "...";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TxtDbName
            // 
            this.TxtDbName.Location = new System.Drawing.Point(271, 13);
            this.TxtDbName.Name = "TxtDbName";
            this.TxtDbName.Size = new System.Drawing.Size(226, 20);
            this.TxtDbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database Name";
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(503, 12);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 23);
            this.BtnImport.TabIndex = 5;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // ChkDropIfExist
            // 
            this.ChkDropIfExist.AutoSize = true;
            this.ChkDropIfExist.Checked = true;
            this.ChkDropIfExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDropIfExist.Location = new System.Drawing.Point(271, 38);
            this.ChkDropIfExist.Name = "ChkDropIfExist";
            this.ChkDropIfExist.Size = new System.Drawing.Size(83, 17);
            this.ChkDropIfExist.TabIndex = 6;
            this.ChkDropIfExist.Text = "Drop If Exist";
            this.ChkDropIfExist.UseVisualStyleBackColor = true;
            // 
            // ImportDumpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 67);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportDumpFrm";
            this.Text = "Import From File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDbName;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkDropIfExist;
    }
}