using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAO.DAO;

namespace ql_dangky_kinhdoanh
{
    public partial class frmHosodangky : Form
    {
        public frmHosodangky()
        {
            InitializeComponent();
            dshoso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dshoso.AutoGenerateColumns = false;
            dshoso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dshoso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dshoso.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
            resetForm();
            SqlDataAdapter da = hoSoDangKy_DAO.get_loaiHinh();

            DataSet ds = new DataSet();
            da.Fill(ds, "loaihinh");

            comboxLoaiHinh.DisplayMember = "sTenLH";
            comboxLoaiHinh.ValueMember = "iMaLH";
            comboxLoaiHinh.DataSource = ds.Tables["loaihinh"];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] data =
            {
                txtSoHS.Text,
                txtTenCongTy.Text,
                txtDiaChi.Text,
                txtNguoiLienHe.Text,
                txtSDT.Text,
                txtEmail.Text,
                comboxLoaiHinh.SelectedValue.ToString()
            };
            if (txtSoHS.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số hồ sơ không được để trống", "Thông báo !");
            }
            else if (txtTenCongTy.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên công ty không được để trống", "Thông báo !");
            }
            else if (txtSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo !");
            }
            else
            {
                if (btnSave.Text.ToString().Equals("Lưu"))
                {
                    hoSoDangKy_DAO hoSo = new hoSoDangKy_DAO();
                    hoSo.insert_HoSo(data);
                    dshoso.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
                    resetForm();
                    MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo !");
                }
                else
                {
                    hoSoDangKy_DAO hoSo = new hoSoDangKy_DAO();
                    hoSo.update_HoSo(data);
                    dshoso.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
                    resetForm();
                    MessageBox.Show("Cập nhật hồ sơ thành công!", "Thông báo !");
                }
            }
        }
        public void resetForm()
        {
            txtSoHS.Enabled = false;
            txtSoHS.Text = hoSoDangKy_DAO.max_soHS();
            txtTenCongTy.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtNguoiLienHe.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtEmail.Text = String.Empty;
            btnSave.Text = "Lưu";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSoHS.Enabled = false;
            int rowindex = dshoso.CurrentCell.RowIndex;

            txtSoHS.Text = dshoso.Rows[rowindex].Cells[0].Value.ToString();
            txtTenCongTy.Text = dshoso.Rows[rowindex].Cells[1].Value.ToString();
            txtDiaChi.Text = dshoso.Rows[rowindex].Cells[2].Value.ToString();
            txtNguoiLienHe.Text = dshoso.Rows[rowindex].Cells[3].Value.ToString();
            txtSDT.Text = dshoso.Rows[rowindex].Cells[4].Value.ToString();
            txtEmail.Text = dshoso.Rows[rowindex].Cells[5].Value.ToString();
            comboxLoaiHinh.Text = dshoso.Rows[rowindex].Cells[6].Value.ToString();

            btnSave.Text = "Cập nhật";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa hồ sơ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                int rowindex = dshoso.CurrentCell.RowIndex;

                hoSoDangKy_DAO.del_HoSo(dshoso.Rows[rowindex].Cells[0].Value.ToString());
                resetForm();
                dshoso.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            Regex regex = new Regex(@"^ (\+[0 - 9]{ 9})$");
            if (!regex.IsMatch(sdt))
            {
                MessageBox.Show("Số điện thoại nhập sai định dạng. Vui lòng nhập lại.!");
            }
        }
    }
}
