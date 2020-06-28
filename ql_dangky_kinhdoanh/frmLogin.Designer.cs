namespace ql_dangky_kinhdoanh
{
    partial class frmLogin
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox checkHienthi;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label lbMatkhau;
        internal System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label lbTaikhoan;
        private System.Windows.Forms.Label lbLogin;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.checkHienthi = new System.Windows.Forms.CheckBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.lbTaikhoan = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 226);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.checkHienthi);
            this.panel2.Controls.Add(this.txtMatkhau);
            this.panel2.Controls.Add(this.lbMatkhau);
            this.panel2.Controls.Add(this.txtTaikhoan);
            this.panel2.Controls.Add(this.lbTaikhoan);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 165);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Location = new System.Drawing.Point(233, 118);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.Location = new System.Drawing.Point(79, 118);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Đăng nhập";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // checkHienthi
            // 
            this.checkHienthi.AutoSize = true;
            this.checkHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHienthi.Location = new System.Drawing.Point(118, 83);
            this.checkHienthi.Name = "checkHienthi";
            this.checkHienthi.Size = new System.Drawing.Size(128, 20);
            this.checkHienthi.TabIndex = 3;
            this.checkHienthi.Text = "Hiển thị mật khẩu";
            this.checkHienthi.UseVisualStyleBackColor = true;
            this.checkHienthi.CheckedChanged += new System.EventHandler(this.checkHienthi_CheckedChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(118, 46);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(176, 20);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatkhau_KeyPress);
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(47, 49);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(65, 16);
            this.lbMatkhau.TabIndex = 2;
            this.lbMatkhau.Text = "Mật khẩu:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(118, 10);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(176, 20);
            this.txtTaikhoan.TabIndex = 1;
            this.txtTaikhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaikhoan_KeyPress);
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan.Location = new System.Drawing.Point(44, 13);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(71, 16);
            this.lbTaikhoan.TabIndex = 0;
            this.lbTaikhoan.Text = "Tài khoản:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLogin.Location = new System.Drawing.Point(87, 20);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(222, 20);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(394, 229);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}