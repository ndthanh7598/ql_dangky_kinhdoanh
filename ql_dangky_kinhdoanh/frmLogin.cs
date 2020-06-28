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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                this.Hide();
                main.Show();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string check = Session.check_login(txtTaikhoan.Text, txtMatkhau.Text);
            if (check.Equals("saitk"))
            {
                MessageBox.Show("Tài khoản, mật khẩu không đúng hoặc đã bị khoá.", "Thông báo!");
            }
            else if (check.Equals("notcnn"))
            {
                MessageBox.Show("Không kết nối được với db", "Thông báo!");
            }
            else if (int.Parse(check) == 2)
            {
                frmMenunhanvien nhanvien = new frmMenunhanvien();
                nhanvien.Show();
                this.Hide();
            }
            else if (int.Parse(check) == 1)
            {
                frmMenuquanly ql = new frmMenuquanly();
                ql.Show();
                this.Hide();
            }
        }

        private void checkHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienthi.Checked)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void txtTaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((Char)Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((Char)Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
