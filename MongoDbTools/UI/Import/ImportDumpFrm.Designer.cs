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
            this.ChkDropIfExist = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDbName = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LoadingLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkDropIfExist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDbName);
            this.panel1.Controls.Add(this.BtnSelectFile);
            this.panel1.Controls.Add(this.TxtPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 12, 0, 0);
            this.panel1.Size = new System.Drawing.Size(771, 70);
            this.panel1.TabIndex = 0;
            // 
            // ChkDropIfExist
            // 
            this.ChkDropIfExist.AutoSize = true;
            this.ChkDropIfExist.Checked = true;
            this.ChkDropIfExist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDropIfExist.Location = new System.Drawing.Point(598, 31);
            this.ChkDropIfExist.Margin = new System.Windows.Forms.Padding(4);
            this.ChkDropIfExist.Name = "ChkDropIfExist";
            this.ChkDropIfExist.Size = new System.Drawing.Size(106, 21);
            this.ChkDropIfExist.TabIndex = 6;
            this.ChkDropIfExist.Text = "Drop If Exist";
            this.ChkDropIfExist.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database Name";
            // 
            // TxtDbName
            // 
            this.TxtDbName.Location = new System.Drawing.Point(328, 28);
            this.TxtDbName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDbName.Name = "TxtDbName";
            this.TxtDbName.Size = new System.Drawing.Size(263, 24);
            this.TxtDbName.TabIndex = 3;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(284, 26);
            this.BtnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(38, 28);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "...";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtPath.Location = new System.Drawing.Point(11, 29);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(266, 24);
            this.TxtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BackUp File Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnImport
            // 
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImport.Image = global::MongoDbTools.Properties.Resources.apply_32x32;
            this.BtnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImport.Location = new System.Drawing.Point(631, 78);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(126, 53);
            this.BtnImport.TabIndex = 5;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // LoadingImg
            // 
            this.LoadingImg.Image = global::MongoDbTools.Properties.Resources.ConnectingLoader;
            this.LoadingImg.Location = new System.Drawing.Point(270, 78);
            this.LoadingImg.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(203, 42);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingImg.TabIndex = 12;
            this.LoadingImg.TabStop = false;
            this.LoadingImg.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // LoadingLbl
            // 
            this.LoadingLbl.AutoSize = true;
            this.LoadingLbl.Location = new System.Drawing.Point(325, 123);
            this.LoadingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingLbl.Name = "LoadingLbl";
            this.LoadingLbl.Size = new System.Drawing.Size(74, 17);
            this.LoadingLbl.TabIndex = 7;
            this.LoadingLbl.Text = "Restoring..";
            this.LoadingLbl.Visible = false;
            // 
            // ImportDumpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 144);
            this.Controls.Add(this.LoadingLbl);
            this.Controls.Add(this.LoadingImg);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportDumpFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import From File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox LoadingImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LoadingLbl;
    }
}