namespace MongoDbTools
{
    partial class NewConnectionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnectionFrm));
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.NumPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.RdNoAuth = new System.Windows.Forms.RadioButton();
            this.RdAuth = new System.Windows.Forms.RadioButton();
            this.TxtConnectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAuth = new System.Windows.Forms.Panel();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAuthDb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InputPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnTestConnection = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.grpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
            this.PnlAuth.SuspendLayout();
            this.InputPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.NumPort);
            this.grpServer.Controls.Add(this.label3);
            this.grpServer.Controls.Add(this.label2);
            this.grpServer.Controls.Add(this.TxtServer);
            this.grpServer.Location = new System.Drawing.Point(3, 80);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(290, 58);
            this.grpServer.TabIndex = 0;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server Info";
            // 
            // NumPort
            // 
            this.NumPort.Location = new System.Drawing.Point(221, 33);
            this.NumPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumPort.Name = "NumPort";
            this.NumPort.Size = new System.Drawing.Size(63, 20);
            this.NumPort.TabIndex = 7;
            this.NumPort.Value = new decimal(new int[] {
            27017,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server";
            // 
            // TxtServer
            // 
            this.TxtServer.Location = new System.Drawing.Point(12, 33);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(203, 20);
            this.TxtServer.TabIndex = 0;
            this.TxtServer.Text = "localhost";
            // 
            // RdNoAuth
            // 
            this.RdNoAuth.AutoSize = true;
            this.RdNoAuth.Checked = true;
            this.RdNoAuth.Location = new System.Drawing.Point(9, 6);
            this.RdNoAuth.Name = "RdNoAuth";
            this.RdNoAuth.Size = new System.Drawing.Size(64, 17);
            this.RdNoAuth.TabIndex = 1;
            this.RdNoAuth.TabStop = true;
            this.RdNoAuth.Text = "No Auth";
            this.RdNoAuth.UseVisualStyleBackColor = true;
            this.RdNoAuth.CheckedChanged += new System.EventHandler(this.RdAuth_CheckedChanged);
            // 
            // RdAuth
            // 
            this.RdAuth.AutoSize = true;
            this.RdAuth.Location = new System.Drawing.Point(79, 6);
            this.RdAuth.Name = "RdAuth";
            this.RdAuth.Size = new System.Drawing.Size(76, 17);
            this.RdAuth.TabIndex = 2;
            this.RdAuth.Text = "Basic Auth";
            this.RdAuth.UseVisualStyleBackColor = true;
            this.RdAuth.CheckedChanged += new System.EventHandler(this.RdAuth_CheckedChanged);
            // 
            // TxtConnectionName
            // 
            this.TxtConnectionName.Location = new System.Drawing.Point(3, 16);
            this.TxtConnectionName.Name = "TxtConnectionName";
            this.TxtConnectionName.Size = new System.Drawing.Size(269, 20);
            this.TxtConnectionName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Name ";
            // 
            // PnlAuth
            // 
            this.PnlAuth.Controls.Add(this.BtnShowPassword);
            this.PnlAuth.Controls.Add(this.label6);
            this.PnlAuth.Controls.Add(this.TxtAuthDb);
            this.PnlAuth.Controls.Add(this.label5);
            this.PnlAuth.Controls.Add(this.TxtPassword);
            this.PnlAuth.Controls.Add(this.label4);
            this.PnlAuth.Controls.Add(this.TxtUserName);
            this.PnlAuth.Location = new System.Drawing.Point(3, 144);
            this.PnlAuth.Name = "PnlAuth";
            this.PnlAuth.Size = new System.Drawing.Size(278, 121);
            this.PnlAuth.TabIndex = 8;
            this.PnlAuth.Visible = false;
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowPassword.Image = global::MongoDbTools.Properties.Resources.show_16x16;
            this.BtnShowPassword.Location = new System.Drawing.Point(225, 56);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(20, 20);
            this.BtnShowPassword.TabIndex = 12;
            this.toolTip1.SetToolTip(this.BtnShowPassword, "Show/hide Password");
            this.BtnShowPassword.UseVisualStyleBackColor = true;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Auth DB";
            // 
            // TxtAuthDb
            // 
            this.TxtAuthDb.Location = new System.Drawing.Point(9, 98);
            this.TxtAuthDb.Name = "TxtAuthDb";
            this.TxtAuthDb.Size = new System.Drawing.Size(209, 20);
            this.TxtAuthDb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(9, 56);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(209, 20);
            this.TxtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserName";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(6, 17);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(209, 20);
            this.TxtUserName.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // InputPnl
            // 
            this.InputPnl.Controls.Add(this.label1);
            this.InputPnl.Controls.Add(this.TxtConnectionName);
            this.InputPnl.Controls.Add(this.panel1);
            this.InputPnl.Controls.Add(this.grpServer);
            this.InputPnl.Controls.Add(this.PnlAuth);
            this.InputPnl.Controls.Add(this.panel2);
            this.InputPnl.Location = new System.Drawing.Point(12, 12);
            this.InputPnl.Name = "InputPnl";
            this.InputPnl.Size = new System.Drawing.Size(308, 312);
            this.InputPnl.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdAuth);
            this.panel1.Controls.Add(this.RdNoAuth);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnTestConnection);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Location = new System.Drawing.Point(3, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 36);
            this.panel2.TabIndex = 13;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(211, 8);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnTestConnection
            // 
            this.BtnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTestConnection.Image = global::MongoDbTools.Properties.Resources.forcetesting_16x16;
            this.BtnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTestConnection.Location = new System.Drawing.Point(3, 8);
            this.BtnTestConnection.Name = "BtnTestConnection";
            this.BtnTestConnection.Size = new System.Drawing.Size(121, 23);
            this.BtnTestConnection.TabIndex = 5;
            this.BtnTestConnection.Text = "Test Connection";
            this.BtnTestConnection.UseVisualStyleBackColor = true;
            this.BtnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(130, 8);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoadingImg
            // 
            this.LoadingImg.Image = global::MongoDbTools.Properties.Resources.ConnectingLoader;
            this.LoadingImg.Location = new System.Drawing.Point(75, 320);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(174, 34);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingImg.TabIndex = 11;
            this.LoadingImg.TabStop = false;
            this.LoadingImg.Visible = false;
            // 
            // NewConnectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 356);
            this.Controls.Add(this.InputPnl);
            this.Controls.Add(this.LoadingImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConnectionFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Conenction";
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
            this.PnlAuth.ResumeLayout(false);
            this.PnlAuth.PerformLayout();
            this.InputPnl.ResumeLayout(false);
            this.InputPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.RadioButton RdNoAuth;
        private System.Windows.Forms.RadioButton RdAuth;
        private System.Windows.Forms.NumericUpDown NumPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.TextBox TxtConnectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAuthDb;
        private System.Windows.Forms.Button BtnTestConnection;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnShowPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox LoadingImg;
        private System.Windows.Forms.FlowLayoutPanel InputPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}