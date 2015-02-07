namespace PicturePeice
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ئېچىشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.تاللاشلارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Easy_F5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Medimum_F6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hard_F7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picPuzzle = new System.Windows.Forms.PictureBox();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPuzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ئېچىشToolStripMenuItem,
            this.تاللاشلارToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(378, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ئېچىشToolStripMenuItem
            // 
            this.ئېچىشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem1});
            this.ئېچىشToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold);
            this.ئېچىشToolStripMenuItem.Name = "ئېچىشToolStripMenuItem";
            this.ئېچىشToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.ئېچىشToolStripMenuItem.Text = "ھۆججەت";
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.Open_ToolStripMenuItem.Text = "ئېچىش ";
            this.Open_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // Exit_ToolStripMenuItem1
            // 
            this.Exit_ToolStripMenuItem1.Name = "Exit_ToolStripMenuItem1";
            this.Exit_ToolStripMenuItem1.Size = new System.Drawing.Size(200, 36);
            this.Exit_ToolStripMenuItem1.Text = "تاقاش";
            this.Exit_ToolStripMenuItem1.Click += new System.EventHandler(this.Exit_ToolStripMenuItem1_Click);
            // 
            // تاللاشلارToolStripMenuItem
            // 
            this.تاللاشلارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Easy_F5ToolStripMenuItem,
            this.Medimum_F6ToolStripMenuItem,
            this.Hard_F7ToolStripMenuItem});
            this.تاللاشلارToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold);
            this.تاللاشلارToolStripMenuItem.Name = "تاللاشلارToolStripMenuItem";
            this.تاللاشلارToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.تاللاشلارToolStripMenuItem.Text = "تاللاشلار";
            // 
            // Easy_F5ToolStripMenuItem
            // 
            this.Easy_F5ToolStripMenuItem.Name = "Easy_F5ToolStripMenuItem";
            this.Easy_F5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Easy_F5ToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.Easy_F5ToolStripMenuItem.Tag = "200";
            this.Easy_F5ToolStripMenuItem.Text = "ئاسان ";
            this.Easy_F5ToolStripMenuItem.Click += new System.EventHandler(this.mnuOptionsLevel_Click);
            // 
            // Medimum_F6ToolStripMenuItem
            // 
            this.Medimum_F6ToolStripMenuItem.Name = "Medimum_F6ToolStripMenuItem";
            this.Medimum_F6ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.Medimum_F6ToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.Medimum_F6ToolStripMenuItem.Tag = "100";
            this.Medimum_F6ToolStripMenuItem.Text = "ئوتتۇراھال ";
            this.Medimum_F6ToolStripMenuItem.Click += new System.EventHandler(this.mnuOptionsLevel_Click);
            // 
            // Hard_F7ToolStripMenuItem
            // 
            this.Hard_F7ToolStripMenuItem.Name = "Hard_F7ToolStripMenuItem";
            this.Hard_F7ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.Hard_F7ToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.Hard_F7ToolStripMenuItem.Tag = "50";
            this.Hard_F7ToolStripMenuItem.Text = "قېيىن";
            this.Hard_F7ToolStripMenuItem.Click += new System.EventHandler(this.mnuOptionsLevel_Click);
            // 
            // picPuzzle
            // 
            this.picPuzzle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPuzzle.Location = new System.Drawing.Point(13, 43);
            this.picPuzzle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picPuzzle.Name = "picPuzzle";
            this.picPuzzle.Size = new System.Drawing.Size(52, 52);
            this.picPuzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPuzzle.TabIndex = 1;
            this.picPuzzle.TabStop = false;
            this.picPuzzle.Visible = false;
            this.picPuzzle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseDown);
            this.picPuzzle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseMove);
            this.picPuzzle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseUp);
            // 
            // ofdPicture
            // 
            this.ofdPicture.Filter = "Graphics Files|*.jpg;*.gif;*.png|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.picPuzzle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رەسىم قوراشتۇرۇش ئويۇنى";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPuzzle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ئېچىشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picPuzzle;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem تاللاشلارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Easy_F5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Medimum_F6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Hard_F7ToolStripMenuItem;
    }
}

