namespace MongoDbTools
{
    partial class ExportToDbFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToDbFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNewConnection = new System.Windows.Forms.ToolStripButton();
            this.BtnExport = new System.Windows.Forms.ToolStripButton();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionTree = new System.Windows.Forms.TreeView();
            this.PnlNewDb = new System.Windows.Forms.Panel();
            this.TxtNewDbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkCreateDatabase = new System.Windows.Forms.CheckBox();
            this.ConnectionsGrid = new System.Windows.Forms.DataGridView();
            this.mDTServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IconCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.connectionAliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useAuthDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlNewDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDTServerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewConnection,
            this.BtnExport,
            this.BtnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(575, 25);
            this.toolStrip1.TabIndex = 1;
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
            // BtnExport
            // 
            this.BtnExport.Image = global::MongoDbTools.Properties.Resources.apply_16x16;
            this.BtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(60, 22);
            this.BtnExport.Text = "Export";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(63, 22);
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnectionTree);
            this.panel1.Controls.Add(this.PnlNewDb);
            this.panel1.Controls.Add(this.ChkCreateDatabase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(405, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(170, 212);
            this.panel1.TabIndex = 3;
            // 
            // ConnectionTree
            // 
            this.ConnectionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree.Location = new System.Drawing.Point(5, 52);
            this.ConnectionTree.Name = "ConnectionTree";
            this.ConnectionTree.Size = new System.Drawing.Size(160, 155);
            this.ConnectionTree.TabIndex = 9;
            // 
            // PnlNewDb
            // 
            this.PnlNewDb.Controls.Add(this.TxtNewDbName);
            this.PnlNewDb.Controls.Add(this.label1);
            this.PnlNewDb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNewDb.Location = new System.Drawing.Point(5, 22);
            this.PnlNewDb.Name = "PnlNewDb";
            this.PnlNewDb.Size = new System.Drawing.Size(160, 30);
            this.PnlNewDb.TabIndex = 8;
            this.PnlNewDb.Visible = false;
            // 
            // TxtNewDbName
            // 
            this.TxtNewDbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNewDbName.Location = new System.Drawing.Point(0, 13);
            this.TxtNewDbName.Name = "TxtNewDbName";
            this.TxtNewDbName.Size = new System.Drawing.Size(160, 20);
            this.TxtNewDbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Db Name";
            // 
            // ChkCreateDatabase
            // 
            this.ChkCreateDatabase.AutoSize = true;
            this.ChkCreateDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChkCreateDatabase.Location = new System.Drawing.Point(5, 5);
            this.ChkCreateDatabase.Name = "ChkCreateDatabase";
            this.ChkCreateDatabase.Size = new System.Drawing.Size(160, 17);
            this.ChkCreateDatabase.TabIndex = 7;
            this.ChkCreateDatabase.Text = "Create New Database";
            this.ChkCreateDatabase.UseVisualStyleBackColor = true;
            this.ChkCreateDatabase.CheckedChanged += new System.EventHandler(this.ChkCreateDatabase_CheckedChanged);
            // 
            // ConnectionsGrid
            // 
            this.ConnectionsGrid.AllowUserToAddRows = false;
            this.ConnectionsGrid.AllowUserToDeleteRows = false;
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
            this.ConnectionsGrid.DataSource = this.mDTServerBindingSource;
            this.ConnectionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConnectionsGrid.Location = new System.Drawing.Point(0, 25);
            this.ConnectionsGrid.Name = "ConnectionsGrid";
            this.ConnectionsGrid.ReadOnly = true;
            this.ConnectionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectionsGrid.Size = new System.Drawing.Size(405, 212);
            this.ConnectionsGrid.TabIndex = 4;
            this.ConnectionsGrid.SelectionChanged += new System.EventHandler(this.ConnectionsGrid_SelectionChanged);
            // 
            // mDTServerBindingSource
            // 
            this.mDTServerBindingSource.DataSource = typeof(MongoConnection.Data.MDTServer);
            // 
            // IconCol
            // 
            this.IconCol.FillWeight = 20F;
            this.IconCol.HeaderText = "";
            this.IconCol.Image = global::MongoDbTools.Properties.Resources.database_16x16;
            this.IconCol.Name = "IconCol";
            this.IconCol.ReadOnly = true;
            // 
            // connectionAliasDataGridViewTextBoxColumn
            // 
            this.connectionAliasDataGridViewTextBoxColumn.DataPropertyName = "ConnectionAlias";
            this.connectionAliasDataGridViewTextBoxColumn.HeaderText = "ConnectionAlias";
            this.connectionAliasDataGridViewTextBoxColumn.Name = "connectionAliasDataGridViewTextBoxColumn";
            this.connectionAliasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            this.serverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useAuthDataGridViewCheckBoxColumn
            // 
            this.useAuthDataGridViewCheckBoxColumn.DataPropertyName = "UseAuth";
            this.useAuthDataGridViewCheckBoxColumn.HeaderText = "UseAuth";
            this.useAuthDataGridViewCheckBoxColumn.Name = "useAuthDataGridViewCheckBoxColumn";
            this.useAuthDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ExportToDbFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 237);
            this.Controls.Add(this.ConnectionsGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportToDbFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportToDbFrm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlNewDb.ResumeLayout(false);
            this.PnlNewDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDTServerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ConnectionsGrid;
        private System.Windows.Forms.ToolStripButton BtnNewConnection;
        private System.Windows.Forms.ToolStripButton BtnExport;
        private System.Windows.Forms.BindingSource mDTServerBindingSource;
        private System.Windows.Forms.Panel PnlNewDb;
        private System.Windows.Forms.TextBox TxtNewDbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkCreateDatabase;
        private System.Windows.Forms.TreeView ConnectionTree;
        private System.Windows.Forms.DataGridViewImageColumn IconCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionAliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useAuthDataGridViewCheckBoxColumn;
    }
}