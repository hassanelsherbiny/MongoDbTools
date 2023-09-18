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
            this.BtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.BtnMigrator = new System.Windows.Forms.ToolStripButton();
            this.BtnSettings = new System.Windows.Forms.ToolStripButton();
            this.ConnectionImageList = new System.Windows.Forms.ImageList(this.components);
            this.DbContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnImportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportDb = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDropDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAddDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnServerDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnServerRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRestoreDb = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LocalHostMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnLocalHostStart = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLocalHostStop = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLocalHostRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLocalHostState = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocalHostChecker = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConnectionTree = new System.Windows.Forms.TreeView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogTxt = new System.Windows.Forms.TextBox();
            this.CollectionExplorer = new System.Windows.Forms.TabControl();
            this.LogImageList = new System.Windows.Forms.ImageList(this.components);
            this.CollectionContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDeleteCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.CollectionExplorerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnCloseTabExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseAllTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseAllButThis = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseTabsToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseTabsToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.DbContextMenu.SuspendLayout();
            this.ServerContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LocalHostMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.CollectionContext.SuspendLayout();
            this.CollectionExplorerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConnect,
            this.BtnDisconnect,
            this.BtnMigrator,
            this.BtnSettings});
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
            // BtnDisconnect
            // 
            this.BtnDisconnect.Image = global::MongoDbTools.Properties.Resources.deletedatasource2_32x32;
            this.BtnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(102, 47);
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnMigrator
            // 
            this.BtnMigrator.Image = global::MongoDbTools.Properties.Resources.sortgroupheader_32x32;
            this.BtnMigrator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMigrator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMigrator.Name = "BtnMigrator";
            this.BtnMigrator.Size = new System.Drawing.Size(89, 47);
            this.BtnMigrator.Text = "Migrator";
            this.BtnMigrator.Click += new System.EventHandler(this.BtnMigrator_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Image = global::MongoDbTools.Properties.Resources.technology_32x32;
            this.BtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(85, 47);
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
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
            this.BtnImportJson,
            this.BtnExportDb,
            this.BtnRpt,
            this.BtnDropDatabase});
            this.DbContextMenu.Name = "DbContextMenu";
            this.DbContextMenu.Size = new System.Drawing.Size(176, 114);
            // 
            // BtnImport
            // 
            this.BtnImport.Image = global::MongoDbTools.Properties.Resources.converttorange_16x16;
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(175, 22);
            this.BtnImport.Text = "Import";
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnImportJson
            // 
            this.BtnImportJson.Image = global::MongoDbTools.Properties.Resources.converttorange_16x16;
            this.BtnImportJson.Name = "BtnImportJson";
            this.BtnImportJson.Size = new System.Drawing.Size(175, 22);
            this.BtnImportJson.Text = "Import From Json";
            this.BtnImportJson.Click += new System.EventHandler(this.BtnImportJson_Click);
            // 
            // BtnExportDb
            // 
            this.BtnExportDb.Image = global::MongoDbTools.Properties.Resources.export_16x16;
            this.BtnExportDb.Name = "BtnExportDb";
            this.BtnExportDb.Size = new System.Drawing.Size(175, 22);
            this.BtnExportDb.Text = "Export";
            this.BtnExportDb.Click += new System.EventHandler(this.BtnExportDb_Click);
            // 
            // BtnRpt
            // 
            this.BtnRpt.Name = "BtnRpt";
            this.BtnRpt.Size = new System.Drawing.Size(175, 22);
            this.BtnRpt.Text = "Report";
            this.BtnRpt.Click += new System.EventHandler(this.BtnRpt_Click);
            // 
            // BtnDropDatabase
            // 
            this.BtnDropDatabase.Image = global::MongoDbTools.Properties.Resources.delete_16x16;
            this.BtnDropDatabase.Name = "BtnDropDatabase";
            this.BtnDropDatabase.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.BtnDropDatabase.Size = new System.Drawing.Size(175, 22);
            this.BtnDropDatabase.Text = "Drop Database";
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
            this.ServerContextMenu.Size = new System.Drawing.Size(165, 92);
            // 
            // BtnAddDataBase
            // 
            this.BtnAddDataBase.Image = global::MongoDbTools.Properties.Resources.addnewdatasource_16x16;
            this.BtnAddDataBase.Name = "BtnAddDataBase";
            this.BtnAddDataBase.Size = new System.Drawing.Size(164, 22);
            this.BtnAddDataBase.Text = "Add Database";
            this.BtnAddDataBase.Click += new System.EventHandler(this.BtnAddDataBase_Click);
            // 
            // BtnServerDisconnect
            // 
            this.BtnServerDisconnect.Image = global::MongoDbTools.Properties.Resources.deletedatasource_16x16;
            this.BtnServerDisconnect.Name = "BtnServerDisconnect";
            this.BtnServerDisconnect.Size = new System.Drawing.Size(164, 22);
            this.BtnServerDisconnect.Text = "Disconnect";
            this.BtnServerDisconnect.Click += new System.EventHandler(this.BtnServerDisconnect_Click);
            // 
            // BtnServerRefresh
            // 
            this.BtnServerRefresh.Image = global::MongoDbTools.Properties.Resources.refresh_16x16;
            this.BtnServerRefresh.Name = "BtnServerRefresh";
            this.BtnServerRefresh.Size = new System.Drawing.Size(164, 22);
            this.BtnServerRefresh.Text = "Refresh";
            this.BtnServerRefresh.Click += new System.EventHandler(this.BtnServerRefresh_Click);
            // 
            // BtnRestoreDb
            // 
            this.BtnRestoreDb.Name = "BtnRestoreDb";
            this.BtnRestoreDb.Size = new System.Drawing.Size(164, 22);
            this.BtnRestoreDb.Text = "Restore Database";
            this.BtnRestoreDb.Click += new System.EventHandler(this.BtnRestoreDb_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CollectionExplorer);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 378);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(262, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ConnectionTree);
            this.tabPage1.Controls.Add(this.TxtSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Connections";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ConnectionTree
            // 
            this.ConnectionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree.ImageIndex = 0;
            this.ConnectionTree.ImageList = this.ConnectionImageList;
            this.ConnectionTree.Location = new System.Drawing.Point(3, 36);
            this.ConnectionTree.Name = "ConnectionTree";
            this.ConnectionTree.SelectedImageIndex = 0;
            this.ConnectionTree.Size = new System.Drawing.Size(248, 313);
            this.ConnectionTree.TabIndex = 4;
            this.ConnectionTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.ConnectionTree_BeforeExpand);
            this.ConnectionTree.DoubleClick += new System.EventHandler(this.ConnectionTree_DoubleClick);
            this.ConnectionTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionTree_KeyDown);
            this.ConnectionTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConnectionTree_MouseUp);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSearch.Location = new System.Drawing.Point(3, 16);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(248, 20);
            this.TxtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(254, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogTxt
            // 
            this.LogTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTxt.Location = new System.Drawing.Point(3, 3);
            this.LogTxt.Multiline = true;
            this.LogTxt.Name = "LogTxt";
            this.LogTxt.ReadOnly = true;
            this.LogTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTxt.Size = new System.Drawing.Size(248, 346);
            this.LogTxt.TabIndex = 0;
            // 
            // CollectionExplorer
            // 
            this.CollectionExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionExplorer.Location = new System.Drawing.Point(0, 0);
            this.CollectionExplorer.Name = "CollectionExplorer";
            this.CollectionExplorer.Padding = new System.Drawing.Point(15, 3);
            this.CollectionExplorer.SelectedIndex = 0;
            this.CollectionExplorer.Size = new System.Drawing.Size(858, 378);
            this.CollectionExplorer.TabIndex = 1;
            this.CollectionExplorer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CollectionExplorer_MouseDown);
            // 
            // LogImageList
            // 
            this.LogImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LogImageList.ImageStream")));
            this.LogImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.LogImageList.Images.SetKeyName(0, "time_16x16.png");
            this.LogImageList.Images.SetKeyName(1, "apply_16x16.png");
            this.LogImageList.Images.SetKeyName(2, "cancel_16x16.png");
            // 
            // CollectionContext
            // 
            this.CollectionContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.BtnDeleteCollection});
            this.CollectionContext.Name = "CollectionContext";
            this.CollectionContext.Size = new System.Drawing.Size(182, 92);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::MongoDbTools.Properties.Resources.export_16x16;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::MongoDbTools.Properties.Resources.converttorange_16x16;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Image = global::MongoDbTools.Properties.Resources.replace_16x16;
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // BtnDeleteCollection
            // 
            this.BtnDeleteCollection.Image = global::MongoDbTools.Properties.Resources.delete_16x16;
            this.BtnDeleteCollection.Name = "BtnDeleteCollection";
            this.BtnDeleteCollection.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.BtnDeleteCollection.Size = new System.Drawing.Size(181, 22);
            this.BtnDeleteCollection.Text = "Drop Collection";
            this.BtnDeleteCollection.Click += new System.EventHandler(this.BtnDeleteCollection_Click);
            // 
            // CollectionExplorerMenu
            // 
            this.CollectionExplorerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCloseTabExplorer,
            this.BtnCloseAllTabs,
            this.BtnCloseAllButThis,
            this.BtnCloseTabsToRight,
            this.BtnCloseTabsToLeft});
            this.CollectionExplorerMenu.Name = "CollectionExplorerMenu";
            this.CollectionExplorerMenu.Size = new System.Drawing.Size(168, 114);
            // 
            // BtnCloseTabExplorer
            // 
            this.BtnCloseTabExplorer.Name = "BtnCloseTabExplorer";
            this.BtnCloseTabExplorer.Size = new System.Drawing.Size(167, 22);
            this.BtnCloseTabExplorer.Text = "Close";
            this.BtnCloseTabExplorer.Click += new System.EventHandler(this.BtnCloseTabExplorer_Click);
            // 
            // BtnCloseAllTabs
            // 
            this.BtnCloseAllTabs.Name = "BtnCloseAllTabs";
            this.BtnCloseAllTabs.Size = new System.Drawing.Size(167, 22);
            this.BtnCloseAllTabs.Text = "Close All";
            this.BtnCloseAllTabs.Click += new System.EventHandler(this.BtnCloseAllTabs_Click);
            // 
            // BtnCloseAllButThis
            // 
            this.BtnCloseAllButThis.Name = "BtnCloseAllButThis";
            this.BtnCloseAllButThis.Size = new System.Drawing.Size(167, 22);
            this.BtnCloseAllButThis.Text = "Close All But This";
            this.BtnCloseAllButThis.Click += new System.EventHandler(this.BtnCloseAllButThis_Click);
            // 
            // BtnCloseTabsToRight
            // 
            this.BtnCloseTabsToRight.Name = "BtnCloseTabsToRight";
            this.BtnCloseTabsToRight.Size = new System.Drawing.Size(167, 22);
            this.BtnCloseTabsToRight.Text = "Close All To Right";
            this.BtnCloseTabsToRight.Click += new System.EventHandler(this.BtnCloseTabsToRight_Click);
            // 
            // BtnCloseTabsToLeft
            // 
            this.BtnCloseTabsToLeft.Name = "BtnCloseTabsToLeft";
            this.BtnCloseTabsToLeft.Size = new System.Drawing.Size(167, 22);
            this.BtnCloseTabsToLeft.Text = "Close All To Left";
            this.BtnCloseTabsToLeft.Click += new System.EventHandler(this.BtnCloseTabsToLeft_Click);
          
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 450);
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.CollectionContext.ResumeLayout(false);
            this.CollectionExplorerMenu.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList LogImageList;
        private System.Windows.Forms.ToolStripMenuItem BtnImport;
        private System.Windows.Forms.ToolStripMenuItem BtnRestoreDb;
        private System.Windows.Forms.TabControl CollectionExplorer;
        private System.Windows.Forms.ContextMenuStrip CollectionContext;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnDeleteCollection;
        private System.Windows.Forms.ToolStripButton BtnDisconnect;
        private System.Windows.Forms.ToolStripMenuItem BtnImportJson;
        private System.Windows.Forms.ContextMenuStrip CollectionExplorerMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseTabExplorer;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseAllTabs;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseAllButThis;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseTabsToRight;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseTabsToLeft;
        private System.Windows.Forms.ToolStripButton BtnMigrator;
        private System.Windows.Forms.ToolStripMenuItem BtnRpt;
        private System.Windows.Forms.TextBox LogTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView ConnectionTree;
        private System.Windows.Forms.ToolStripButton BtnSettings;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
    }
}

