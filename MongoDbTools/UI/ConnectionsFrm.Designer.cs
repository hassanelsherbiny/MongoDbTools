namespace MongoDbTools
{
    partial class ConnectionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionsFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNewConnection = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.ConnectionsGrid = new System.Windows.Forms.DataGridView();
            this.IconCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.connectionAliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useAuthDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ConnectMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mDTServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDTServerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewConnection,
            this.BtnEdit,
            this.BtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNewConnection
            // 
            this.BtnNewConnection.Image = global::MongoDbTools.Properties.Resources.addnewdatasource_32x32;
            this.BtnNewConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewConnection.Name = "BtnNewConnection";
            this.BtnNewConnection.Size = new System.Drawing.Size(116, 22);
            this.BtnNewConnection.Text = "New Connection";
            this.BtnNewConnection.Click += new System.EventHandler(this.BtnNewConnection_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::MongoDbTools.Properties.Resources.editdatasource_32x32;
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(112, 22);
            this.BtnEdit.Text = "Edit Connection";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(125, 22);
            this.BtnDelete.Text = "Delete Connection";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ConnectionsGrid
            // 
            this.ConnectionsGrid.AutoGenerateColumns = false;
            this.ConnectionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConnectionsGrid.BackgroundColor = System.Drawing.Color.White;
            this.ConnectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconCol,
            this.connectionAliasDataGridViewTextBoxColumn,
            this.serverDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.useAuthDataGridViewCheckBoxColumn});
            this.ConnectionsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.ConnectionsGrid.DataSource = this.mDTServerBindingSource;
            this.ConnectionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConnectionsGrid.Location = new System.Drawing.Point(0, 25);
            this.ConnectionsGrid.Name = "ConnectionsGrid";
            this.ConnectionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectionsGrid.Size = new System.Drawing.Size(800, 270);
            this.ConnectionsGrid.TabIndex = 1;
            this.ConnectionsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConnectionsGrid_CellMouseDoubleClick);
            this.ConnectionsGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionsGrid_MouseDown);
            // 
            // IconCol
            // 
            this.IconCol.FillWeight = 20F;
            this.IconCol.HeaderText = "";
            this.IconCol.Image = global::MongoDbTools.Properties.Resources.database_16x16;
            this.IconCol.Name = "IconCol";
            // 
            // connectionAliasDataGridViewTextBoxColumn
            // 
            this.connectionAliasDataGridViewTextBoxColumn.DataPropertyName = "ConnectionAlias";
            this.connectionAliasDataGridViewTextBoxColumn.HeaderText = "ConnectionAlias";
            this.connectionAliasDataGridViewTextBoxColumn.Name = "connectionAliasDataGridViewTextBoxColumn";
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // useAuthDataGridViewCheckBoxColumn
            // 
            this.useAuthDataGridViewCheckBoxColumn.DataPropertyName = "UseAuth";
            this.useAuthDataGridViewCheckBoxColumn.HeaderText = "Use Auth";
            this.useAuthDataGridViewCheckBoxColumn.Name = "useAuthDataGridViewCheckBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectMenuBtn,
            this.EditMenuBtn,
            this.DeleteMenuBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // ConnectMenuBtn
            // 
            this.ConnectMenuBtn.Image = global::MongoDbTools.Properties.Resources.radio_32x32;
            this.ConnectMenuBtn.Name = "ConnectMenuBtn";
            this.ConnectMenuBtn.Size = new System.Drawing.Size(119, 22);
            this.ConnectMenuBtn.Text = "Connect";
            this.ConnectMenuBtn.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EditMenuBtn
            // 
            this.EditMenuBtn.Image = global::MongoDbTools.Properties.Resources.editdatasource_32x32;
            this.EditMenuBtn.Name = "EditMenuBtn";
            this.EditMenuBtn.Size = new System.Drawing.Size(119, 22);
            this.EditMenuBtn.Text = "Edit";
            this.EditMenuBtn.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DeleteMenuBtn
            // 
            this.DeleteMenuBtn.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.DeleteMenuBtn.Name = "DeleteMenuBtn";
            this.DeleteMenuBtn.Size = new System.Drawing.Size(119, 22);
            this.DeleteMenuBtn.Text = "Delete";
            this.DeleteMenuBtn.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // mDTServerBindingSource
            // 
            this.mDTServerBindingSource.DataSource = typeof(MongoConnection.Data.MDTServer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadingImg);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
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
            this.BtnClose.Location = new System.Drawing.Point(703, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 32);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.Image = global::MongoDbTools.Properties.Resources.radio_32x32;
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnect.Location = new System.Drawing.Point(607, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(90, 32);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MongoDbTools.Properties.Resources.database_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 757;
            // 
            // ConnectionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectionsGrid);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionsFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.ConnectionsFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDTServerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView ConnectionsGrid;
        private System.Windows.Forms.ToolStripButton BtnNewConnection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.BindingSource mDTServerBindingSource;
        private System.Windows.Forms.PictureBox LoadingImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConnectMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem EditMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuBtn;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.DataGridViewImageColumn IconCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionAliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useAuthDataGridViewCheckBoxColumn;
    }
}