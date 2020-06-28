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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            frmDSHS tracuu = new frmDSHS();
            tracuu.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin dangnhap = new frmLogin();
            dangnhap.Show();
            this.Hide();
        }
    }
}
