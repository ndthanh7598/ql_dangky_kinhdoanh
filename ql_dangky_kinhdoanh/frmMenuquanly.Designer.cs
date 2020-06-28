namespace ql_dangky_kinhdoanh
{
    partial class frmMenuquanly
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
            this.menuQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsHSDK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.dsNhanVienNghiHuu = new System.Windows.Forms.ToolStripMenuItem();
            this.dshosotheodk = new System.Windows.Forms.ToolStripMenuItem();
            this.dshosotheodate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHethong,
            this.menuQuanly,
            this.menuBaocao,
            this.menuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
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
            // menuQuanly
            // 
            this.menuQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemsHSDK,
            this.menuItemNV});
            this.menuQuanly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuQuanly.Name = "menuQuanly";
            this.menuQuanly.Size = new System.Drawing.Size(68, 20);
            this.menuQuanly.Text = "QUẢN LÝ";
            // 
            // menuItemsHSDK
            // 
            this.menuItemsHSDK.Name = "menuItemsHSDK";
            this.menuItemsHSDK.Size = new System.Drawing.Size(149, 22);
            this.menuItemsHSDK.Text = "DUYỆT HỒ SƠ";
            this.menuItemsHSDK.Click += new System.EventHandler(this.menuItemsHSDK_Click);
            // 
            // menuItemNV
            // 
            this.menuItemNV.Name = "menuItemNV";
            this.menuItemNV.Size = new System.Drawing.Size(149, 22);
            this.menuItemNV.Text = "NHÂN VIÊN";
            this.menuItemNV.Click += new System.EventHandler(this.menuItemNV_Click);
            // 
            // menuBaocao
            // 
            this.menuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsNhanVienNghiHuu,
            this.dshosotheodk,
            this.dshosotheodate});
            this.menuBaocao.Name = "menuBaocao";
            this.menuBaocao.Size = new System.Drawing.Size(77, 20);
            this.menuBaocao.Text = "THỐNG KÊ";
            // 
            // dsNhanVienNghiHuu
            // 
            this.dsNhanVienNghiHuu.Name = "dsNhanVienNghiHuu";
            this.dsNhanVienNghiHuu.Size = new System.Drawing.Size(328, 22);
            this.dsNhanVienNghiHuu.Text = "DANH SÁCH NHÂN VIÊN ĐÃ NGHỈ HƯU";
            this.dsNhanVienNghiHuu.Click += new System.EventHandler(this.dsNhanVienNghiHuu_Click);
            // 
            // dshosotheodk
            // 
            this.dshosotheodk.Name = "dshosotheodk";
            this.dshosotheodk.Size = new System.Drawing.Size(328, 22);
            this.dshosotheodk.Text = "DANH SÁCH HỒ SƠ ĐÃ DUYỆT";
            this.dshosotheodk.Click += new System.EventHandler(this.dshosotheodk_Click);
            // 
            // dshosotheodate
            // 
            this.dshosotheodate.Name = "dshosotheodate";
            this.dshosotheodate.Size = new System.Drawing.Size(328, 22);
            this.dshosotheodate.Text = "DANH SÁCH HỒ SƠ THEO NGÀY/THÁNG/NĂM";
            this.dshosotheodate.Click += new System.EventHandler(this.dshosotheodate_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(85, 20);
            this.menuLogout.Text = "ĐĂNG XUẤT";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // frmMenuquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ql_dangky_kinhdoanh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1031, 560);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu quản lý";
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
        private System.Windows.Forms.ToolStripMenuItem menuQuanly;
        private System.Windows.Forms.ToolStripMenuItem menuItemsHSDK;
        private System.Windows.Forms.ToolStripMenuItem menuItemNV;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuBaocao;
        private System.Windows.Forms.ToolStripMenuItem dsNhanVienNghiHuu;
        private System.Windows.Forms.ToolStripMenuItem dshosotheodk;
        private System.Windows.Forms.ToolStripMenuItem dshosotheodate;
    }
}