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
    public partial class frmDuyetHoSo : Form
    {
        public frmDuyetHoSo()
        {
            InitializeComponent();

            dsDuyetHS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDuyetHS.AutoGenerateColumns = false;
            dsDuyetHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsDuyetHS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dsDuyetHS.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            int rowindex = dsDuyetHS.CurrentCell.RowIndex;

            string soHS = dsDuyetHS.Rows[rowindex].Cells[0].Value.ToString();
            string trangthai = dsDuyetHS.Rows[rowindex].Cells[6].Value.ToString();

            if (trangthai.Equals("chờ duyệt"))
            {
                hoSoDangKy_DAO.update_trangthai(soHS, "đã duyệt");
                dsDuyetHS.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
                dsDuyetHS.Rows[rowindex].Cells[6].Style.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Duyệt hồ sơ thành công!", "Thông báo !");
            }
            else
            {
                MessageBox.Show("Hồ sơ đã được duyệt hoặc đã bị huỷ!", "Thông báo !");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int rowindex = dsDuyetHS.CurrentCell.RowIndex;

            string soHS = dsDuyetHS.Rows[rowindex].Cells[0].Value.ToString();
            string trangthai = dsDuyetHS.Rows[rowindex].Cells[6].Value.ToString();

            if (trangthai.Equals("đã duyệt"))
            {
                MessageBox.Show("Hồ sơ đã được duyệt nên không thể huỷ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!trangthai.Equals("đã huỷ"))
            {
                hoSoDangKy_DAO.update_trangthai(soHS, "đã huỷ");
                dsDuyetHS.DataSource = hoSoDangKy_DAO.get_DanhSachHoSo();
                dsDuyetHS.Rows[rowindex].Cells[6].Style.ForeColor = System.Drawing.Color.Violet;
                MessageBox.Show("Huỷ hồ sơ thành công!", "Thông báo !");
            }
            else
            {
                MessageBox.Show("Hồ sơ đã bị huỷ trước đó!", "Thông báo !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
