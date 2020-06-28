using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_dangky_kinhdoanh
{
    public partial class frmMenuquanly : Form
    {
        public frmMenuquanly()
        {
            InitializeComponent();
        }
        private void menuItemsHSDK_Click(object sender, EventArgs e)
        {
            frmDuyetHoSo duyetHS = new frmDuyetHoSo();
            duyetHS.MdiParent = this;
            duyetHS.Show();
        }

        private void menuItemNV_Click(object sender, EventArgs e)
        {
            frmNhanvien nhanvien = new frmNhanvien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void menuItemsTTCN_Click(object sender, EventArgs e)
        {
            frmThongtincanhan info = new frmThongtincanhan();
            info.MdiParent = this;
            info.Show();
        }

        private void menuItemsDMK_Click(object sender, EventArgs e)
        {
            frmChangePass dmk = new frmChangePass();
            dmk.MdiParent = this;
            dmk.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void dshosotheodk_Click(object sender, EventArgs e)
        {
            dshosodaduyet dshoso = new dshosodaduyet();
            dshoso.Show();
        }

        private void dsNhanVienNghiHuu_Click(object sender, EventArgs e)
        {
            dsnhanviennghihuu dsnhanvien = new dsnhanviennghihuu();
            dsnhanvien.Show();
        }

        private void dshosotheodate_Click(object sender, EventArgs e)
        {
            dshosotheodk dshosotheodate = new dshosotheodk();
            dshosotheodate.Show();
        }
    }
}
