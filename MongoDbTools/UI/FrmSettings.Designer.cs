namespace MongoDbTools
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChkStartLocalServiceWithStartUp = new System.Windows.Forms.CheckBox();
            this.txtMongoInstallationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalHostDataFilesPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConnections = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadingImg);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 39);
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
            this.BtnClose.Location = new System.Drawing.Point(251, 5);
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
            this.BtnSave.Location = new System.Drawing.Point(155, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(90, 32);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MongoDbTools.Properties.Resources.database_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 757;
            // 
            // ChkStartLocalServiceWithStartUp
            // 
            this.ChkStartLocalServiceWithStartUp.AutoSize = true;
            this.ChkStartLocalServiceWithStartUp.Location = new System.Drawing.Point(12, 12);
            this.ChkStartLocalServiceWithStartUp.Name = "ChkStartLocalServiceWithStartUp";
            this.ChkStartLocalServiceWithStartUp.Size = new System.Drawing.Size(178, 17);
            this.ChkStartLocalServiceWithStartUp.TabIndex = 3;
            this.ChkStartLocalServiceWithStartUp.Text = "Start Local Service With Startup";
            this.ChkStartLocalServiceWithStartUp.UseVisualStyleBackColor = true;
            // 
            // txtMongoInstallationPath
            // 
            this.txtMongoInstallationPath.Location = new System.Drawing.Point(12, 48);
            this.txtMongoInstallationPath.Name = "txtMongoInstallationPath";
            this.txtMongoInstallationPath.Size = new System.Drawing.Size(324, 20);
            this.txtMongoInstallationPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mongo Installation Path (Mongod.Exe)";
            // 
            // txtLocalHostDataFilesPath
            // 
            this.txtLocalHostDataFilesPath.Location = new System.Drawing.Point(12, 89);
            this.txtLocalHostDataFilesPath.Name = "txtLocalHostDataFilesPath";
            this.txtLocalHostDataFilesPath.Size = new System.Drawing.Size(324, 20);
            this.txtLocalHostDataFilesPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LocalHost Data Files Path";
            // 
            // BtnConnections
            // 
            this.BtnConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnections.Image = global::MongoDbTools.Properties.Resources.radio_32x32;
            this.BtnConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnections.Location = new System.Drawing.Point(117, 127);
            this.BtnConnections.Name = "BtnConnections";
            this.BtnConnections.Size = new System.Drawing.Size(113, 32);
            this.BtnConnections.TabIndex = 6;
            this.BtnConnections.Text = "Connections";
            this.BtnConnections.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConnections.UseVisualStyleBackColor = true;
            this.BtnConnections.Click += new System.EventHandler(this.BtnConnections_Click);
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 204);
            this.Controls.Add(this.BtnConnections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalHostDataFilesPath);
            this.Controls.Add(this.txtMongoInstallationPath);
            this.Controls.Add(this.ChkStartLocalServiceWithStartUp);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox LoadingImg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.CheckBox ChkStartLocalServiceWithStartUp;
        private System.Windows.Forms.TextBox txtMongoInstallationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalHostDataFilesPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConnections;
    }
}