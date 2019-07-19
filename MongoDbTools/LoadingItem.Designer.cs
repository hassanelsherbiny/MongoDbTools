namespace MongoDbTools
{
    partial class LoadingItem
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
            this.LblTask = new System.Windows.Forms.Label();
            this.LblProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTask
            // 
            this.LblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTask.Location = new System.Drawing.Point(0, 0);
            this.LblTask.Name = "LblTask";
            this.LblTask.Size = new System.Drawing.Size(242, 18);
            this.LblTask.TabIndex = 0;
            this.LblTask.Text = "label1";
            this.LblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblProgress
            // 
            this.LblProgress.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblProgress.Location = new System.Drawing.Point(206, 0);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(36, 18);
            this.LblProgress.TabIndex = 2;
            this.LblProgress.Text = "100%";
            this.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MongoDbTools.Properties.Resources.cancel_16x16;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 18);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTask);
            this.Name = "LoadingItem";
            this.Size = new System.Drawing.Size(242, 18);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblProgress;
    }
}
