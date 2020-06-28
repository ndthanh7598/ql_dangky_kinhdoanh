using CrystalDecisions.CrystalReports.Engine;
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
    public partial class dshosotheodk : Form
    {
        public dshosotheodk()
        {
            InitializeComponent();
            List<string> day = new List<string>();
            List<string> month = new List<string>();
            List<int> year = new List<int>();
            day.Add("");
            for (int j = 1; j < 32; j++)
            {
                if (j < 10)
                {
                    day.Add("0" + j.ToString());
                }
                else
                {
                    day.Add(j.ToString());
                }
            }
            cbxNgay.DataSource = day;
            month.Add("");
            for (int i = 1; i < 13; i++)
            {
                if (i < 10)
                {
                    month.Add("0" + i.ToString());
                }
                else
                {
                    month.Add(i.ToString());
                }
            }
            cbxThang.DataSource = month;
            for (int z = 2018; z > 1989; z--)
            {
                year.Add(z);
            }
            cbxNam.DataSource = year;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (hoSoDangKy_DAO.get_hosotheodk(cbxNgay.SelectedValue.ToString(), cbxThang.SelectedValue.ToString(), cbxNam.SelectedValue.ToString()))
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"F:\BTL\ql_dangky_kinhdoanh\ql_dangky_kinhdoanh\exportHoSoTheoDieuKien.rpt");
                cryRpt.SetParameterValue("@Day", cbxNgay.SelectedValue.ToString());
                cryRpt.SetParameterValue("@Thang", cbxThang.SelectedValue.ToString());
                cryRpt.SetParameterValue("@Year", cbxNam.SelectedValue.ToString());
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày - tháng - năm !", "Thông báo !");
            }
        }
    }
}
