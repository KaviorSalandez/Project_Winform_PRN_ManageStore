namespace Project_WinForm_PRN211
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.System_icon;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // changePassToolStripMenuItem
            // 
            this.changePassToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.App_password_icon;
            this.changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            this.changePassToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.changePassToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePassToolStripMenuItem.Click += new System.EventHandler(this.changePassToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.My_Computer_icon;
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.folder_flower_black_icon;
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brandToolStripMenuItem.Text = "Thương hiệu";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.folder_flower_green_icon;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoryToolStripMenuItem.Text = "Loại bàn phím";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.folder_flower_lila_icon;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productToolStripMenuItem.Text = "Bàn phím";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeAccountToolStripMenuItem,
            this.customerAccountToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.folder_flower_blue_icon;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản ";
            // 
            // employeeAccountToolStripMenuItem
            // 
            this.employeeAccountToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.Groups_Meeting_Light_icon;
            this.employeeAccountToolStripMenuItem.Name = "employeeAccountToolStripMenuItem";
            this.employeeAccountToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.employeeAccountToolStripMenuItem.Text = "Tài khoản nhân viên";
            this.employeeAccountToolStripMenuItem.Click += new System.EventHandler(this.employeeAccountToolStripMenuItem_Click);
            // 
            // customerAccountToolStripMenuItem
            // 
            this.customerAccountToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources._11875_family_man_woman_boy_boy_icon;
            this.customerAccountToolStripMenuItem.Name = "customerAccountToolStripMenuItem";
            this.customerAccountToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.customerAccountToolStripMenuItem.Text = "Tài khoản khách hàng";
            this.customerAccountToolStripMenuItem.Click += new System.EventHandler(this.customerAccountToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.Occupations_Technical_Support_Representative_Male_Light_icon;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Project_WinForm_PRN211.Properties.Resources.logout_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.exitToolStripMenuItem.Text = "Đăng xuất";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_WinForm_PRN211.Properties.Resources.ban_phim_co_STEELSERIES_21;
            this.pictureBox1.Location = new System.Drawing.Point(2, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1290, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ - Hệ thống quản lí cửa hàng bàn phím cơ Gear2023";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem changePassToolStripMenuItem;
        private ToolStripMenuItem quảnLíToolStripMenuItem;
        private ToolStripMenuItem brandToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem employeeAccountToolStripMenuItem;
        private ToolStripMenuItem customerAccountToolStripMenuItem;
    }
}