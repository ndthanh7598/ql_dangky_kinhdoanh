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
    public partial class frmMenunhanvien : Form
    {
        public frmMenunhanvien()
        {
            InitializeComponent();
        }
        private void menuItemHSDK_Click(object sender, EventArgs e)
        {
            frmHosodangky hoSo = new frmHosodangky();
            hoSo.MdiParent = this;
            hoSo.Show();
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
    }
}
