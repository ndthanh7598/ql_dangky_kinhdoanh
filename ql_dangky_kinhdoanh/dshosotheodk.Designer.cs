namespace ql_dangky_kinhdoanh
{
    partial class dshosotheodk
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnXuat = new System.Windows.Forms.Button();
            this.lblNgay = new System.Windows.Forms.Label();
            this.cbxNgay = new System.Windows.Forms.ComboBox();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 438);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuat.Location = new System.Drawing.Point(713, 444);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(268, 450);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(61, 13);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Chọn ngày:";
            // 
            // cbxNgay
            // 
            this.cbxNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNgay.FormattingEnabled = true;
            this.cbxNgay.Location = new System.Drawing.Point(335, 446);
            this.cbxNgay.Name = "cbxNgay";
            this.cbxNgay.Size = new System.Drawing.Size(63, 21);
            this.cbxNgay.TabIndex = 3;
            // 
            // cbxNam
            // 
            this.cbxNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(626, 446);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(63, 21);
            this.cbxNam.TabIndex = 5;
            // 
            // lblNam
            // 
            this.lblNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(559, 450);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(58, 13);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Chọn năm:";
            // 
            // cbxThang
            // 
            this.cbxThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Location = new System.Drawing.Point(481, 447);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(63, 21);
            this.cbxThang.TabIndex = 7;
            // 
            // lblThang
            // 
            this.lblThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(414, 451);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(65, 13);
            this.lblThang.TabIndex = 6;
            this.lblThang.Text = "Chọn tháng:";
            // 
            // dshosotheodk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.cbxThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.cbxNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "dshosotheodk";
            this.Text = "Danh sách hồ sơ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ComboBox cbxNgay;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Label lblThang;
    }
}