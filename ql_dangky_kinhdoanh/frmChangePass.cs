using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAO.DAO;

namespace ql_dangky_kinhdoanh
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
            txtTendangnhap.Text = Session.get_Session("sTenDangNhap");
            txtTendangnhap.Enabled = false;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim().Equals("") || txtNewPass.Text.Trim().Equals("") || txtXacnhanpass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các trường", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtOldPass.Text.Trim().Equals(txtNewPass.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu cũ và mật khẩu mới không được trùng nhau", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNewPass.Text != txtXacnhanpass.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dangNhap_DAO.checkPass(txtOldPass.Text))
                    {
                        dangNhap_DAO.update_Pass(txtNewPass.Text);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo!");
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtOldPass.Clear();
            txtNewPass.Clear();
            txtXacnhanpass.Clear();
            this.Hide();
        }
    }
}
