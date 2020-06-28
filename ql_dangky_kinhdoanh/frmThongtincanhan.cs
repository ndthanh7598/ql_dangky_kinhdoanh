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
    public partial class frmThongtincanhan : Form
    {
        public frmThongtincanhan()
        {
            InitializeComponent();

            String[] info = canBo_DAO.get_CanBo();
            txtHoten.Text = info[0];
            txtNS.Text = info[1];
            if (info[2].Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtCMT.Text = info[3];
            txtEmail.Text = info[4];
            txtSDT.Text = info[5];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gioitinh = "Nam";
            if (rdNu.Checked)
            {
                gioitinh = "Nữ";
            }
            String[] data = {
                txtHoten.Text,
                txtNS.Text,
                gioitinh,
                txtCMT.Text,
                txtEmail.Text,
                txtSDT.Text
            };
            if (txtHoten.Text.Trim().Equals("") || txtNS.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập họ tên và ngày sinh", "Thông báo!");
            }
            else
            {
                canBo_DAO.update_CB(data);
                MessageBox.Show("Cập nhật thông tin cán bộ thành công!", "Thông báo!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
