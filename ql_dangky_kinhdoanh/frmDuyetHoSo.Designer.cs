namespace ql_dangky_kinhdoanh
{
    partial class frmDuyetHoSo
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
            this.lblDuyetHoSo = new System.Windows.Forms.Label();
            this.dsHSDuyet = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.dsDuyetHS = new System.Windows.Forms.DataGridView();
            this.sSoHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNguoiLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsHSDuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuyetHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDuyetHoSo
            // 
            this.lblDuyetHoSo.AutoSize = true;
            this.lblDuyetHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuyetHoSo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDuyetHoSo.Location = new System.Drawing.Point(304, 26);
            this.lblDuyetHoSo.Name = "lblDuyetHoSo";
            this.lblDuyetHoSo.Size = new System.Drawing.Size(168, 25);
            this.lblDuyetHoSo.TabIndex = 4;
            this.lblDuyetHoSo.Text = "DUYỆT HỒ SƠ";
            // 
            // dsHSDuyet
            // 
            this.dsHSDuyet.Controls.Add(this.btnThoat);
            this.dsHSDuyet.Controls.Add(this.btnHuy);
            this.dsHSDuyet.Controls.Add(this.btnDuyet);
            this.dsHSDuyet.Controls.Add(this.dsDuyetHS);
            this.dsHSDuyet.Location = new System.Drawing.Point(12, 54);
            this.dsHSDuyet.Name = "dsHSDuyet";
            this.dsHSDuyet.Size = new System.Drawing.Size(763, 222);
            this.dsHSDuyet.TabIndex = 5;
            this.dsHSDuyet.TabStop = false;
            this.dsHSDuyet.Text = "Danh sách hồ sơ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(662, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(129, 183);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Huỷ hồ sơ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(26, 183);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(75, 23);
            this.btnDuyet.TabIndex = 1;
            this.btnDuyet.Text = "Duyệt hồ sơ";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // dsDuyetHS
            // 
            this.dsDuyetHS.AllowUserToAddRows = false;
            this.dsDuyetHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDuyetHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoHoSo,
            this.sTenCongTy,
            this.sDiaChi,
            this.sNguoiLienHe,
            this.sSDTLienHe,
            this.sEmail,
            this.sTrangThai});
            this.dsDuyetHS.Location = new System.Drawing.Point(7, 31);
            this.dsDuyetHS.Name = "dsDuyetHS";
            this.dsDuyetHS.Size = new System.Drawing.Size(750, 131);
            this.dsDuyetHS.TabIndex = 0;
            // 
            // sSoHoSo
            // 
            this.sSoHoSo.DataPropertyName = "sSoHoSo";
            this.sSoHoSo.HeaderText = "Số HS";
            this.sSoHoSo.Name = "sSoHoSo";
            this.sSoHoSo.ReadOnly = true;
            // 
            // sTenCongTy
            // 
            this.sTenCongTy.DataPropertyName = "sTenCongTy";
            this.sTenCongTy.HeaderText = "Tên công ty";
            this.sTenCongTy.Name = "sTenCongTy";
            this.sTenCongTy.ReadOnly = true;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.ReadOnly = true;
            // 
            // sNguoiLienHe
            // 
            this.sNguoiLienHe.DataPropertyName = "sNguoiLienHe";
            this.sNguoiLienHe.HeaderText = "Người liên hệ";
            this.sNguoiLienHe.Name = "sNguoiLienHe";
            this.sNguoiLienHe.ReadOnly = true;
            // 
            // sSDTLienHe
            // 
            this.sSDTLienHe.DataPropertyName = "sSDTLienHe";
            this.sSDTLienHe.HeaderText = "Số ĐT";
            this.sSDTLienHe.Name = "sSDTLienHe";
            this.sSDTLienHe.ReadOnly = true;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.ReadOnly = true;
            // 
            // sTrangThai
            // 
            this.sTrangThai.DataPropertyName = "sTrangThai";
            this.sTrangThai.HeaderText = "Trạng thái";
            this.sTrangThai.Name = "sTrangThai";
            this.sTrangThai.ReadOnly = true;
            // 
            // frmDuyetHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 279);
            this.Controls.Add(this.dsHSDuyet);
            this.Controls.Add(this.lblDuyetHoSo);
            this.Name = "frmDuyetHoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt hồ sơ";
            this.dsHSDuyet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDuyetHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuyetHoSo;
        private System.Windows.Forms.GroupBox dsHSDuyet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.DataGridView dsDuyetHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangThai;
    }
}