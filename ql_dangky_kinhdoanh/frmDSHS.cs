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
    public partial class frmDSHS : Form
    {
        public frmDSHS()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền số hồ sơ hoặc tên công ty muốn tra cứu", "Thông báo!");
            }
            else
            {
                groupBox2.Visible = true;
                dshoso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dshoso.AutoGenerateColumns = false;
                dshoso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dshoso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dshoso.DataSource = hoSoDangKy_DAO.traCuuHoSo(txtSearch.Text);

                for (int i = 0; i < (dshoso.RowCount - 1); i++)
                {
                    if (dshoso.Rows[i].Cells[6].Value.ToString().Equals("chờ duyệt"))
                    {
                        dshoso.Rows[i].Cells[6].Value = "chờ duyệt";
                        dshoso.Rows[i].Cells[6].Style.ForeColor = Color.Black;
                        dshoso.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                    }
                    if (dshoso.Rows[i].Cells[6].Value.ToString().Equals("đã huỷ"))
                    {
                        dshoso.Rows[i].Cells[6].Value = "đã huỷ";
                        dshoso.Rows[i].Cells[6].Style.ForeColor = Color.White;
                        dshoso.Rows[i].Cells[6].Style.BackColor = Color.Red;
                    }
                    if (dshoso.Rows[i].Cells[6].Value.ToString().Equals("đã duyệt"))
                    {
                        dshoso.Rows[i].Cells[6].Value = "đã duyệt";
                        dshoso.Rows[i].Cells[6].Style.ForeColor = Color.Black;
                        dshoso.Rows[i].Cells[6].Style.BackColor = Color.Green;
                    }
                }
            }
        }
    }
}
