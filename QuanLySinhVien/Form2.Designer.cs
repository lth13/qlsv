namespace QuanLySinhVien
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cviecToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.cáNhânToolStripMenuItem,
            this.thôngBáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(796, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Enabled = false;
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuât";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PbanToolStripMenuItem,
            this.nvienToolStripMenuItem,
            this.cviecToolStripMenuItem1,
            this.thốngKêToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // PbanToolStripMenuItem
            // 
            this.PbanToolStripMenuItem.Enabled = false;
            this.PbanToolStripMenuItem.Name = "PbanToolStripMenuItem";
            this.PbanToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.PbanToolStripMenuItem.Text = "Phòng ban";
            this.PbanToolStripMenuItem.Click += new System.EventHandler(this.PbanToolStripMenuItem_Click);
            // 
            // nvienToolStripMenuItem
            // 
            this.nvienToolStripMenuItem.Enabled = false;
            this.nvienToolStripMenuItem.Name = "nvienToolStripMenuItem";
            this.nvienToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.nvienToolStripMenuItem.Text = "Nhân viên";
            this.nvienToolStripMenuItem.Click += new System.EventHandler(this.nvienToolStripMenuItem_Click);
            // 
            // cviecToolStripMenuItem1
            // 
            this.cviecToolStripMenuItem1.Enabled = false;
            this.cviecToolStripMenuItem1.Name = "cviecToolStripMenuItem1";
            this.cviecToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.cviecToolStripMenuItem1.Text = "Công việc";
            this.cviecToolStripMenuItem1.Click += new System.EventHandler(this.cviecToolStripMenuItem1_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // cáNhânToolStripMenuItem
            // 
            this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.cáNhânToolStripMenuItem.Text = "Cá nhân";
            this.cáNhânToolStripMenuItem.Visible = false;
            this.cáNhânToolStripMenuItem.Click += new System.EventHandler(this.cáNhânToolStripMenuItem_Click);
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngBáoToolStripMenuItem,
            this.tạoThôngBáoToolStripMenuItem});
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo";
            // 
            // xemThôngBáoToolStripMenuItem
            // 
            this.xemThôngBáoToolStripMenuItem.Name = "xemThôngBáoToolStripMenuItem";
            this.xemThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.xemThôngBáoToolStripMenuItem.Text = "Xem thông báo";
            this.xemThôngBáoToolStripMenuItem.Click += new System.EventHandler(this.xemThôngBáoToolStripMenuItem_Click);
            // 
            // tạoThôngBáoToolStripMenuItem
            // 
            this.tạoThôngBáoToolStripMenuItem.Enabled = false;
            this.tạoThôngBáoToolStripMenuItem.Name = "tạoThôngBáoToolStripMenuItem";
            this.tạoThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.tạoThôngBáoToolStripMenuItem.Text = "Tạo thông báo";
            this.tạoThôngBáoToolStripMenuItem.Click += new System.EventHandler(this.tạoThôngBáoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(255, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cviecToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoThôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}