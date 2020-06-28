namespace ql_dangky_kinhdoanh
{
    partial class frmDSHS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dshoso = new System.Windows.Forms.DataGridView();
            this.sSoHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNguoiLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dshoso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(588, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(423, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số HS/Tên công ty:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dshoso);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách công ty";
            this.groupBox2.Visible = false;
            // 
            // dshoso
            // 
            this.dshoso.AllowUserToAddRows = false;
            this.dshoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dshoso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoHoSo,
            this.sTenCongTy,
            this.sDiaChi,
            this.sNguoiLienHe,
            this.sSDTLienHe,
            this.sEmail,
            this.sTrangThai});
            this.dshoso.Location = new System.Drawing.Point(6, 32);
            this.dshoso.Name = "dshoso";
            this.dshoso.Size = new System.Drawing.Size(745, 119);
            this.dshoso.TabIndex = 0;
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
            // frmDSHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDSHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hồ sơ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dshoso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dshoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangThai;
    }
}