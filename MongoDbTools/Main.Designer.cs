namespace MongoDbTools
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnConnect = new System.Windows.Forms.ToolStripButton();
            this.ConnectionImageList = new System.Windows.Forms.ImageList(this.components);
            this.DbContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportDb = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDropDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAddDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnServerDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnServerRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LocalHostMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnLocalHostStart = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLocalHostStop = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLocalHostRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLocalHostState = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocalHostChecker = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogImageList = new System.Windows.Forms.ImageList(this.components);
            this.CollectionExplorerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ConnectionTree = new System.Windows.Forms.TreeView();
            this.BtnRestoreDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.DbContextMenu.SuspendLayout();
            this.ServerContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LocalHostMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CollectionExplorerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1124, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Image = global::MongoDbTools.Properties.Resources.database_32x32;
            this.BtnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(88, 47);
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ConnectionImageList
            // 
            this.ConnectionImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConnectionImageList.ImageStream")));
            this.ConnectionImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ConnectionImageList.Images.SetKeyName(0, "servermode_32x32.png");
            this.ConnectionImageList.Images.SetKeyName(1, "database_32x32.png");
            this.ConnectionImageList.Images.SetKeyName(2, "grandtotalsoffrowscolumnspivottable_32x32.png");
            // 
            // DbContextMenu
            // 
            this.DbContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnImport,
            this.BtnExportDb,
            this.BtnDropDatabase});
            this.DbContextMenu.Name = "DbContextMenu";
            this.DbContextMenu.Size = new System.Drawing.Size(179, 70);
            // 
            // BtnImport
            // 
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(178, 22);
            this.BtnImport.Text = "Import";
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExportDb
            // 
            this.BtnExportDb.Name = "BtnExportDb";
            this.BtnExportDb.Size = new System.Drawing.Size(178, 22);
            this.BtnExportDb.Text = "Export";
            this.BtnExportDb.Click += new System.EventHandler(this.BtnExportDb_Click);
            // 
            // BtnDropDatabase
            // 
            this.BtnDropDatabase.Name = "BtnDropDatabase";
            this.BtnDropDatabase.Size = new System.Drawing.Size(178, 22);
            this.BtnDropDatabase.Text = "Drop Database (del)";
            this.BtnDropDatabase.Click += new System.EventHandler(this.BtnDropDatabase_Click);
            // 
            // ServerContextMenu
            // 
            this.ServerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddDataBase,
            this.BtnServerDisconnect,
            this.BtnServerRefresh,
            this.BtnRestoreDb});
            this.ServerContextMenu.Name = "DbContextMenu";
            this.ServerContextMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // BtnAddDataBase
            // 
            this.BtnAddDataBase.Name = "BtnAddDataBase";
            this.BtnAddDataBase.Size = new System.Drawing.Size(180, 22);
            this.BtnAddDataBase.Text = "Add Database";
            this.BtnAddDataBase.Click += new System.EventHandler(this.BtnAddDataBase_Click);
            // 
            // BtnServerDisconnect
            // 
            this.BtnServerDisconnect.Name = "BtnServerDisconnect";
            this.BtnServerDisconnect.Size = new System.Drawing.Size(180, 22);
            this.BtnServerDisconnect.Text = "Disconnect";
            // 
            // BtnServerRefresh
            // 
            this.BtnServerRefresh.Name = "BtnServerRefresh";
            this.BtnServerRefresh.Size = new System.Drawing.Size(180, 22);
            this.BtnServerRefresh.Text = "Refresh";
            this.BtnServerRefresh.Click += new System.EventHandler(this.BtnServerRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ContextMenuStrip = this.LocalHostMenu;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblLocalHostState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LocalHostMenu
            // 
            this.LocalHostMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLocalHostStart,
            this.BtnLocalHostStop,
            this.BtnLocalHostRestart});
            this.LocalHostMenu.Name = "LocalHostMenu";
            this.LocalHostMenu.Size = new System.Drawing.Size(111, 70);
            // 
            // BtnLocalHostStart
            // 
            this.BtnLocalHostStart.Name = "BtnLocalHostStart";
            this.BtnLocalHostStart.Size = new System.Drawing.Size(110, 22);
            this.BtnLocalHostStart.Text = "Start";
            this.BtnLocalHostStart.Click += new System.EventHandler(this.BtnLocalHostStart_Click);
            // 
            // BtnLocalHostStop
            // 
            this.BtnLocalHostStop.Name = "BtnLocalHostStop";
            this.BtnLocalHostStop.Size = new System.Drawing.Size(110, 22);
            this.BtnLocalHostStop.Text = "Stop";
            this.BtnLocalHostStop.Click += new System.EventHandler(this.BtnLocalHostStop_Click);
            // 
            // BtnLocalHostRestart
            // 
            this.BtnLocalHostRestart.Name = "BtnLocalHostRestart";
            this.BtnLocalHostRestart.Size = new System.Drawing.Size(110, 22);
            this.BtnLocalHostRestart.Text = "Restart";
            this.BtnLocalHostRestart.Click += new System.EventHandler(this.BtnLocalHostRestart_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Local Host : ";
            // 
            // LblLocalHostState
            // 
            this.LblLocalHostState.ForeColor = System.Drawing.Color.Green;
            this.LblLocalHostState.Name = "LblLocalHostState";
            this.LblLocalHostState.Size = new System.Drawing.Size(52, 17);
            this.LblLocalHostState.Text = "Running";
            // 
            // LocalHostChecker
            // 
            this.LocalHostChecker.Enabled = true;
            this.LocalHostChecker.Interval = 1000;
            this.LocalHostChecker.Tick += new System.EventHandler(this.LocalHostChecker_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ConnectionTree);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CollectionExplorerTab);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 378);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 7;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSearch.Location = new System.Drawing.Point(0, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(262, 20);
            this.TxtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // LogImageList
            // 
            this.LogImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LogImageList.ImageStream")));
            this.LogImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.LogImageList.Images.SetKeyName(0, "time_16x16.png");
            this.LogImageList.Images.SetKeyName(1, "apply_16x16.png");
            this.LogImageList.Images.SetKeyName(2, "cancel_16x16.png");
            // 
            // CollectionExplorerTab
            // 
            this.CollectionExplorerTab.Controls.Add(this.tabPage1);
            this.CollectionExplorerTab.Controls.Add(this.tabPage2);
            this.CollectionExplorerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionExplorerTab.Location = new System.Drawing.Point(0, 0);
            this.CollectionExplorerTab.Name = "CollectionExplorerTab";
            this.CollectionExplorerTab.SelectedIndex = 0;
            this.CollectionExplorerTab.Size = new System.Drawing.Size(858, 378);
            this.CollectionExplorerTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(844, 346);
            this.splitContainer2.SplitterDistance = 26;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(844, 316);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::MongoDbTools.Properties.Resources.time_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(655, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // ConnectionTree
            // 
            this.ConnectionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree.ImageIndex = 0;
            this.ConnectionTree.ImageList = this.ConnectionImageList;
            this.ConnectionTree.Location = new System.Drawing.Point(0, 33);
            this.ConnectionTree.Name = "ConnectionTree";
            this.ConnectionTree.SelectedImageIndex = 0;
            this.ConnectionTree.Size = new System.Drawing.Size(262, 345);
            this.ConnectionTree.TabIndex = 4;
            // 
            // BtnRestoreDb
            // 
            this.BtnRestoreDb.Name = "BtnRestoreDb";
            this.BtnRestoreDb.Size = new System.Drawing.Size(180, 22);
            this.BtnRestoreDb.Text = "Restore Database";
            this.BtnRestoreDb.Click += new System.EventHandler(this.BtnRestoreDb_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo DB Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DbContextMenu.ResumeLayout(false);
            this.ServerContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LocalHostMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CollectionExplorerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnConnect;
        private System.Windows.Forms.ImageList ConnectionImageList;
        private System.Windows.Forms.ContextMenuStrip DbContextMenu;
        private System.Windows.Forms.ContextMenuStrip ServerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnExportDb;
        private System.Windows.Forms.ToolStripMenuItem BtnServerDisconnect;
        private System.Windows.Forms.ToolStripMenuItem BtnServerRefresh;
        private System.Windows.Forms.ToolStripMenuItem BtnAddDataBase;
        private System.Windows.Forms.ToolStripMenuItem BtnDropDatabase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblLocalHostState;
        private System.Windows.Forms.Timer LocalHostChecker;
        private System.Windows.Forms.ContextMenuStrip LocalHostMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnLocalHostStart;
        private System.Windows.Forms.ToolStripMenuItem BtnLocalHostStop;
        private System.Windows.Forms.ToolStripMenuItem BtnLocalHostRestart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl CollectionExplorerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList LogImageList;
        private System.Windows.Forms.ToolStripMenuItem BtnImport;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TreeView ConnectionTree;
        private System.Windows.Forms.ToolStripMenuItem BtnRestoreDb;
    }
}

