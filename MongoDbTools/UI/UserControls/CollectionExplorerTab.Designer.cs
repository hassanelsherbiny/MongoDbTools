﻿namespace MongoDbTools
{
    partial class CollectionExplorerTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblCollectionName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFilterValue = new System.Windows.Forms.TextBox();
            this.DDFilterOperator = new System.Windows.Forms.ComboBox();
            this.TxtFilterCol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbItemPerPage = new System.Windows.Forms.ComboBox();
            this.Grv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextHide = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnJsonView = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.LblCollectionName);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.LblSize);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.LblCount);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnReload);
            this.splitContainer1.Panel1.Controls.Add(this.lblPages);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPrev);
            this.splitContainer1.Panel1.Controls.Add(this.BtnNext);
            this.splitContainer1.Panel1.Controls.Add(this.BtnLast);
            this.splitContainer1.Panel1.Controls.Add(this.btnFirst);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CmbItemPerPage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grv);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 615);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // LblCollectionName
            // 
            this.LblCollectionName.AutoSize = true;
            this.LblCollectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCollectionName.Location = new System.Drawing.Point(13, 10);
            this.LblCollectionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCollectionName.Name = "LblCollectionName";
            this.LblCollectionName.Size = new System.Drawing.Size(229, 29);
            this.LblCollectionName.TabIndex = 13;
            this.LblCollectionName.Text = "Database.Collection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "SIZE : ";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(76, 91);
            this.LblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(55, 16);
            this.LblSize.TabIndex = 12;
            this.LblSize.Text = "1500 KB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Documents";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(523, 80);
            this.LblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(59, 16);
            this.LblCount.TabIndex = 12;
            this.LblCount.Text = "50 / 5000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFilterValue);
            this.groupBox1.Controls.Add(this.DDFilterOperator);
            this.groupBox1.Controls.Add(this.TxtFilterCol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(603, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(527, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Value";
            // 
            // TxtFilterValue
            // 
            this.TxtFilterValue.Location = new System.Drawing.Point(277, 37);
            this.TxtFilterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFilterValue.Name = "TxtFilterValue";
            this.TxtFilterValue.Size = new System.Drawing.Size(197, 22);
            this.TxtFilterValue.TabIndex = 12;
            this.TxtFilterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFilterValue_KeyDown);
            // 
            // DDFilterOperator
            // 
            this.DDFilterOperator.FormattingEnabled = true;
            this.DDFilterOperator.Items.AddRange(new object[] {
            "==",
            "!=",
            ">",
            "<",
            "<=",
            ">=",
            "Contains",
            "! Contains"});
            this.DDFilterOperator.Location = new System.Drawing.Point(179, 37);
            this.DDFilterOperator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DDFilterOperator.Name = "DDFilterOperator";
            this.DDFilterOperator.Size = new System.Drawing.Size(89, 24);
            this.DDFilterOperator.TabIndex = 13;
            this.DDFilterOperator.Text = "==";
            // 
            // TxtFilterCol
            // 
            this.TxtFilterCol.Location = new System.Drawing.Point(8, 37);
            this.TxtFilterCol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFilterCol.Name = "TxtFilterCol";
            this.TxtFilterCol.Size = new System.Drawing.Size(161, 22);
            this.TxtFilterCol.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ColumnName";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(523, 43);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(59, 16);
            this.lblPages.TabIndex = 8;
            this.lblPages.Text = "50 / 5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items Per Page";
            // 
            // CmbItemPerPage
            // 
            this.CmbItemPerPage.FormattingEnabled = true;
            this.CmbItemPerPage.Items.AddRange(new object[] {
            "15",
            "50",
            "100",
            "1000",
            "10000",
            "100000"});
            this.CmbItemPerPage.Location = new System.Drawing.Point(19, 62);
            this.CmbItemPerPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbItemPerPage.Name = "CmbItemPerPage";
            this.CmbItemPerPage.Size = new System.Drawing.Size(160, 24);
            this.CmbItemPerPage.TabIndex = 0;
            this.CmbItemPerPage.Text = "15";
            this.CmbItemPerPage.SelectedIndexChanged += new System.EventHandler(this.CmbItemPerPage_SelectedIndexChanged);
            // 
            // Grv
            // 
            this.Grv.AllowUserToDeleteRows = false;
            this.Grv.AllowUserToOrderColumns = true;
            this.Grv.BackgroundColor = System.Drawing.Color.White;
            this.Grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grv.GridColor = System.Drawing.Color.Black;
            this.Grv.Location = new System.Drawing.Point(0, 0);
            this.Grv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grv.Name = "Grv";
            this.Grv.RowHeadersWidth = 51;
            this.Grv.Size = new System.Drawing.Size(1133, 497);
            this.Grv.TabIndex = 2;
            this.Grv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_CellContentDoubleClick);
            this.Grv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_CellDoubleClick);
            this.Grv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grv_CellMouseClick);
            this.Grv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_CellValueChanged);
            this.Grv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grv_ColumnHeaderMouseClick);
            this.Grv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grv_KeyDown);
            this.Grv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grv_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextFilter,
            this.ContextHide,
            this.btnJsonView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // ContextFilter
            // 
            this.ContextFilter.Name = "ContextFilter";
            this.ContextFilter.Size = new System.Drawing.Size(210, 24);
            this.ContextFilter.Text = "Filter";
            this.ContextFilter.Click += new System.EventHandler(this.ContextFilter_Click);
            // 
            // ContextHide
            // 
            this.ContextHide.Name = "ContextHide";
            this.ContextHide.Size = new System.Drawing.Size(210, 24);
            this.ContextHide.Text = "Hide";
            this.ContextHide.Click += new System.EventHandler(this.ContextHide_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFilter.Image = global::MongoDbTools.Properties.Resources.marqueezoom_16x16;
            this.BtnFilter.Location = new System.Drawing.Point(484, 33);
            this.BtnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(32, 30);
            this.BtnFilter.TabIndex = 14;
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReload.Image = global::MongoDbTools.Properties.Resources.refresh_32x32;
            this.BtnReload.Location = new System.Drawing.Point(456, 42);
            this.BtnReload.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(59, 54);
            this.BtnReload.TabIndex = 9;
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrev.Image = global::MongoDbTools.Properties.Resources.doubleprev_32x32;
            this.BtnPrev.Location = new System.Drawing.Point(255, 42);
            this.BtnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(59, 54);
            this.BtnPrev.TabIndex = 7;
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNext.Image = global::MongoDbTools.Properties.Resources.doublenext_32x32;
            this.BtnNext.Location = new System.Drawing.Point(321, 42);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(59, 54);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLast.Image = global::MongoDbTools.Properties.Resources.doublelast_32x32;
            this.BtnLast.Location = new System.Drawing.Point(388, 42);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(59, 54);
            this.BtnLast.TabIndex = 5;
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Image = global::MongoDbTools.Properties.Resources.doublefirst_32x32;
            this.btnFirst.Location = new System.Drawing.Point(188, 43);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(59, 54);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnJsonView
            // 
            this.btnJsonView.Name = "btnJsonView";
            this.btnJsonView.Size = new System.Drawing.Size(210, 24);
            this.btnJsonView.Text = "Json Viewer";
            this.btnJsonView.Click += new System.EventHandler(this.btnJsonView_Click);
            // 
            // CollectionExplorerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CollectionExplorerTab";
            this.Size = new System.Drawing.Size(1133, 615);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Grv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbItemPerPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilterValue;
        private System.Windows.Forms.ComboBox DDFilterOperator;
        private System.Windows.Forms.TextBox TxtFilterCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCollectionName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextFilter;
        private System.Windows.Forms.ToolStripMenuItem ContextHide;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.ToolStripMenuItem btnJsonView;
    }
}
