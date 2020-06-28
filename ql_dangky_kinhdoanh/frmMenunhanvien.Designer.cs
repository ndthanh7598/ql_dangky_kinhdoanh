namespace ql_dangky_kinhdoanh
{
    partial class frmMenunhanvien
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
            this.menuHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHSDK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHethong,
            this.menuItemHSDK,
            this.menuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHethong
            // 
            this.menuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemsTTCN,
            this.menuItemsDMK});
            this.menuHethong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Size = new System.Drawing.Size(79, 20);
            this.menuHethong.Text = "HỆ THỐNG";
            // 
            // menuItemsTTCN
            // 
            this.menuItemsTTCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuItemsTTCN.Name = "menuItemsTTCN";
            this.menuItemsTTCN.Size = new System.Drawing.Size(195, 22);
            this.menuItemsTTCN.Text = "THÔNG TIN CÁ NHÂN";
            this.menuItemsTTCN.Click += new System.EventHandler(this.menuItemsTTCN_Click);
            // 
            // menuItemsDMK
            // 
            this.menuItemsDMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuItemsDMK.Name = "menuItemsDMK";
            this.menuItemsDMK.Size = new System.Drawing.Size(195, 22);
            this.menuItemsDMK.Text = "ĐỔI MẬT KHẨU";
            this.menuItemsDMK.Click += new System.EventHandler(this.menuItemsDMK_Click);
            // 
            // menuItemHSDK
            // 
            this.menuItemHSDK.Name = "menuItemHSDK";
            this.menuItemHSDK.Size = new System.Drawing.Size(185, 20);
            this.menuItemHSDK.Text = "ĐĂNG KÝ HỒ SƠ KINH DOANH";
            this.menuItemHSDK.Click += new System.EventHandler(this.menuItemHSDK_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(85, 20);
            this.menuLogout.Text = "ĐĂNG XUẤT";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // frmMenunhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ql_dangky_kinhdoanh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenunhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu nhân viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHethong;
        private System.Windows.Forms.ToolStripMenuItem menuItemsTTCN;
        private System.Windows.Forms.ToolStripMenuItem menuItemsDMK;
        private System.Windows.Forms.ToolStripMenuItem menuItemHSDK;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
    }
}