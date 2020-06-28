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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();

            dsNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsNV.AutoGenerateColumns = false;
            dsNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dsNV.DataSource = nhanVien_DAO.get_DanhSachNhanVien();

        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            if (btnSaveNV.Text.Equals("Lưu"))
            {
                string gioitinh = "Nam";
                if (rdNu.Checked)
                {
                    gioitinh = "Nữ";
                }
                //MessageBox.Show(dNgaySinh.Value.ToString("dd/MM/yyyy"), "Thông báo !");
                String[] data =
                {
                    txtTenNV.Text,
                    dNgaySinh.Value.ToString("dd/MM/yyyy"),
                    gioitinh,
                    txtCMND.Text,
                    txtEmail.Text,
                    txtPhone.Text
                };
                if (!txtMatkhau.Text.Equals(txtXacnhanMK.Text))
                {
                    MessageBox.Show("Mật khẩu và mật khẩu xác nhận không giống nhau", "Thông báo !");
                }
                else
                {
                    if (txtTenNV.Text.Trim().Equals("") || txtTaiKhoan.Text.Trim().Equals("") || txtMatkhau.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Không được để trống dữ liệu các trường", "Thông báo !");
                    }
                    else
                    {
                        canBo_DAO canBo = new canBo_DAO();
                        canBo.insert_CB(data);
                        Session tk = new Session();
                        nhanVien_DAO.insert_taikhoan(txtTaiKhoan.Text, txtMatkhau.Text);
                        dsNV.DataSource = nhanVien_DAO.get_DanhSachNhanVien();
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo !");
                    }
                }
            }
            else
            {
                if (txtMatkhau.Text.Trim().Equals(txtXacnhanMK.Text.Trim()))
                {
                    string taikhoan = txtTaiKhoan.Text;
                    string manv = nhanVien_DAO.get_maNhanVienTheoTenDN(taikhoan);
                    string gioitinh = "Nam";
                    if (rdNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }
                    String[] data =
                    {
                        txtTenNV.Text,
                        dNgaySinh.Value.ToString("dd/MM/yyyy"),
                        gioitinh,
                        txtCMND.Text,
                        txtEmail.Text,
                        txtPhone.Text
                    };
                    nhanVien_DAO.update_NV(data, manv);
                    if (!txtMatkhau.Text.Trim().Equals(""))
                    {
                        //update mật khẩu theo tên tài khoản truyền vào
                        nhanVien_DAO.update_passTheoTenTK(taikhoan, txtMatkhau.Text.Trim());
                    }
                    dsNV.DataSource = nhanVien_DAO.get_DanhSachNhanVien();
                    resetForm();
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo !");
                }
                else
                {
                    MessageBox.Show("Mật khẩu và mật khẩu xác nhận khác nhau!", "Thông báo!");
                }
            }
        }

        public void resetForm()
        {
            txtTenNV.Text = String.Empty;
            dNgaySinh.Text = String.Empty;
            txtCMND.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Text = String.Empty;
            txtMatkhau.Text = String.Empty;
            txtXacnhanMK.Text = String.Empty;
            btnSaveNV.Text = "Lưu";
        }
        private void btnEditNV_Click(object sender, EventArgs e)
        {
            int rowindex = dsNV.CurrentCell.RowIndex;

            string maNV = dsNV.Rows[rowindex].Cells[1].Value.ToString();

            txtTenNV.Text = dsNV.Rows[rowindex].Cells[2].Value.ToString();
            //dNgaySinh.Text = dsNV.Rows[rowindex].Cells[1].Value.ToString();
            dNgaySinh.Value = DateTime.ParseExact(dsNV.Rows[rowindex].Cells[3].Value.ToString(), "dd/MM/yyyy", null);
            if (dsNV.Rows[rowindex].Cells[4].Value.ToString().Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtCMND.Text = dsNV.Rows[rowindex].Cells[5].Value.ToString();
            txtEmail.Text = dsNV.Rows[rowindex].Cells[6].Value.ToString();
            txtPhone.Text = dsNV.Rows[rowindex].Cells[7].Value.ToString();

            //manv =>  lay
            txtTaiKhoan.Text = nhanVien_DAO.get_tenDangNhapTheoMa(maNV);
            txtTaiKhoan.Enabled = false;


            btnSaveNV.Text = "Cập nhật";
        }

        private void btnBackNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dsNV.Rows.Count; i++)
            {
                int maNV = Convert.ToInt32(dsNV.Rows[i].Cells[1].Value.ToString());

                string trangthai = dsNV.Rows[i].Cells[8].Value.ToString();
                bool isCheck = Convert.ToBoolean(dsNV.Rows[i].Cells["check"].Value);
                if (isCheck)
                {
                    if (trangthai.Equals("bình thường"))
                    {
                        nhanVien_DAO tt_tk = new nhanVien_DAO();
                        tt_tk.update_status_tk(maNV, "khoá");
                        dem++;
                    }
                }
            }
            if (dem > 0)
            {
                dsNV.DataSource = nhanVien_DAO.get_DanhSachNhanVien();
                MessageBox.Show("Khoá tài khoản thành công!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //int rowindex = dsNV.CurrentCell.RowIndex;
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dsNV.Rows.Count; i++)
            {
                int maNV = Convert.ToInt32(dsNV.Rows[i].Cells[1].Value.ToString());

                string trangthai = dsNV.Rows[i].Cells[8].Value.ToString();
                bool isCheck = Convert.ToBoolean(dsNV.Rows[i].Cells["check"].Value);
                if (isCheck)
                {
                    if (trangthai.Equals("khoá"))
                    {
                        nhanVien_DAO tt_tk = new nhanVien_DAO();
                        tt_tk.update_status_tk(maNV, "bình thường");
                        dem++;
                    }
                }
            }
            if (dem > 0)
            {
                dsNV.DataSource = nhanVien_DAO.get_DanhSachNhanVien();
                MessageBox.Show("Mở khoá tài khoản thành công!", "Thông báo !");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
