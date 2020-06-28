using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO
    {
        public class SqlConnectionData
        {
            public static SqlConnection connect()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8JHRFJR\TUYENDO;Initial Catalog=ql_dangky_kinhdoanh;Integrated Security=True");
                return conn;
            }

        }
        public class Session
        {
            public static string check_login(string taikhoan, string matkhau)
            {
                string tk = null, quyen = "2", maCB = null;
                try
                {
                    SqlConnection conn = SqlConnectionData.connect();
                    SqlCommand cmd = new SqlCommand("sp_check_dangnhap", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTaikhoan", taikhoan);
                    cmd.Parameters.AddWithValue("@sMatKhau", matkhau);
                    conn.Open();
                    SqlDataReader dar = cmd.ExecuteReader();
                    if (dar.HasRows)
                    {
                        while (dar.Read())
                        {
                            tk = dar["sTenDangNhap"].ToString();
                            quyen = dar["FK_iMaQuyen"].ToString();
                            maCB = dar["FK_iMaCB"].ToString();
                        }
                    }
                    else
                    {
                        return "saitk";
                    }
                    conn.Close();
                    SqlCommand cmdSS = new SqlCommand("sp_session", conn);
                    cmdSS.CommandType = CommandType.StoredProcedure;
                    cmdSS.Parameters.AddWithValue("@sTenDangNhap", tk);
                    cmdSS.Parameters.AddWithValue("@FK_iMaQuyen", int.Parse(quyen));
                    cmdSS.Parameters.AddWithValue("@FK_iMaCB", int.Parse(maCB));
                    conn.Open();
                    SqlDataReader darSS = cmdSS.ExecuteReader();
                    conn.Close();
                }
                catch (Exception)
                {
                    return "notcnn";
                }
                return quyen;
            }
            public static String get_Session(string name)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("get_session", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dar = cmd.ExecuteReader();
                while (dar.Read())
                {
                    return dar[name].ToString();
                }
                Conn.Close();
                return null;
            }
        }
        public class hoSoDangKy_DAO
        {
            public static DataTable traCuuHoSo(string search)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_tracuuhoso", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sSoHoSo", search);
                cmd.Parameters.AddWithValue("@sTenCongTy", search);
                DataTable dtb = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtb);
                return dtb;
            }

            public static DataTable get_DanhSachHoSo()
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_hosodangky", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SELECT");
                cmd.Parameters.AddWithValue("@iQuyen", Session.get_Session("FK_iMaQuyen"));
                DataTable dtb = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtb);
                return dtb;
            }
            public static SqlDataAdapter get_loaiHinh()
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_loaihinh", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Conn.Close();
                return da;

            }
            public void insert_HoSo(String[] data)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_hosodangky", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@sSoHS", data[0]);
                cmd.Parameters.AddWithValue("@sTenCongTy", data[1]);
                cmd.Parameters.AddWithValue("@sDiaChi", data[2]);
                cmd.Parameters.AddWithValue("@sNguoiLienHe", data[3]);
                cmd.Parameters.AddWithValue("@sSDTLienHe", data[4]);
                cmd.Parameters.AddWithValue("@sEmail", data[5]);
                cmd.Parameters.AddWithValue("@iLoaiHinh", data[6]);
                cmd.Parameters.AddWithValue("@iMaCB", Session.get_Session("FK_iMaCB"));
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            public void update_HoSo(String[] data)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_hosodangky", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@sSoHS", data[0]);
                cmd.Parameters.AddWithValue("@sTenCongTy", data[1]);
                cmd.Parameters.AddWithValue("@sDiaChi", data[2]);
                cmd.Parameters.AddWithValue("@sNguoiLienHe", data[3]);
                cmd.Parameters.AddWithValue("@sSDTLienHe", data[4]);
                cmd.Parameters.AddWithValue("@sEmail", data[5]);
                cmd.Parameters.AddWithValue("@iLoaiHinh", data[6]);
                cmd.Parameters.AddWithValue("@iMaCB", Session.get_Session("FK_iMaCB"));
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            public static void del_HoSo(string sSoHoSo)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_hosodangky", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "DELETE");
                cmd.Parameters.AddWithValue("@sSoHS", sSoHoSo);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            public static void update_trangthai(string soHS, string trangthai)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_update_trangthai", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sSoHS", soHS);
                cmd.Parameters.AddWithValue("@sTrangthai", trangthai);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            public static String max_soHS()
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_maxSoHS", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dar = cmd.ExecuteReader();
                String ma = "1";
                while (dar.Read())
                {
                    ma = dar["iMaHS_Max"].ToString();
                }
                Conn.Close();
                String maHS = "HS0" + (Convert.ToInt32(ma)).ToString();
                return maHS;
            }
            public static bool get_hosotheodk(string ngay, string thang, string nam)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_get_hosotheodieukien", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Day", ngay);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Year", nam);

                Conn.Open();
                SqlDataReader dar = cmd.ExecuteReader();
                if (dar.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class canBo_DAO
        {
            public static String[] get_CanBo()
            {
                String[] info = new String[100];
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_canbo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SELECT");
                cmd.Parameters.AddWithValue("@iMaCanBo", Session.get_Session("FK_iMaCB"));
                SqlDataReader dar = cmd.ExecuteReader();
                while (dar.Read())
                {
                    info[0] = dar["sTenCB"].ToString();
                    info[1] = dar["sNgaySinh"].ToString();
                    info[2] = dar["sGioiTinh"].ToString();
                    info[3] = dar["sCMT"].ToString();
                    info[4] = dar["sEmail"].ToString();
                    info[5] = dar["sSDT"].ToString();
                }
                Conn.Close();
                return info;
            }

            public void insert_CB(String[] data)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_canbo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Action", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sTenCB", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sNgaySinh", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@sGioiTinh", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@sCMT", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sEmail", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sSDT", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@iMaCanBo", SqlDbType.NVarChar, 100);

                cmd.Parameters["@Action"].Value = "INSERT";
                cmd.Parameters["@sTenCB"].Value = data[0];
                cmd.Parameters["@sNgaySinh"].Value = data[1];
                cmd.Parameters["@sGioiTinh"].Value = data[2];
                cmd.Parameters["@sCMT"].Value = data[3];
                cmd.Parameters["@sEmail"].Value = data[4];
                cmd.Parameters["@sSDT"].Value = data[5];
                cmd.Parameters["@iMaCanBo"].Value = Session.get_Session("FK_iMaCB");
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            public static void update_CB(String[] data)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_canbo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@sTenCB", data[0]);
                cmd.Parameters.AddWithValue("@sNgaySinh", data[1]);
                cmd.Parameters.AddWithValue("@sGioiTinh", data[2]);
                cmd.Parameters.AddWithValue("@sCMT", data[3]);
                cmd.Parameters.AddWithValue("@sEmail", data[4]);
                cmd.Parameters.AddWithValue("@sSDT", data[5]);
                cmd.Parameters.AddWithValue("@iMaCanBo", Session.get_Session("FK_iMaCB"));

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }
        public class dangNhap_DAO
        {
            public static void update_Pass(String newpass)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("update_password", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sTaikhoan", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sMatKhau", SqlDbType.NVarChar, 50);

                cmd.Parameters["@sTaikhoan"].Value = Session.get_Session("sTenDangNhap");
                cmd.Parameters["@sMatKhau"].Value = newpass;
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            public static Boolean checkPass(string sMatKhau)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_check_dangnhap", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sTaikhoan", Session.get_Session("sTenDangNhap"));
                cmd.Parameters.AddWithValue("@sMatKhau", sMatKhau);
                SqlDataReader dar = cmd.ExecuteReader();
                if (dar.HasRows)
                {
                    Conn.Close();
                    return true;
                }
                else
                {
                    Conn.Close();
                    return false;
                }
            }
        }
        public class nhanVien_DAO
        {
            public static DataTable get_DanhSachNhanVien()
            {
                SqlConnection conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_get_nhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtb = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtb);   // đổ dữ liệu
                return dtb;
            }

            public static String max_iMaCB(string iMaCanBo)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_maNhanVienMax", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dar = cmd.ExecuteReader();
                while (dar.Read())
                {
                    return dar["iMaCB_Max"].ToString();
                }
                Conn.Close();
                return null;
            }

            public static void insert_taikhoan(string tk, string mk)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_insert_taikhoan", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sTaikhoan", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sMatKhau", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@iMaCB", SqlDbType.NVarChar, 50);

                cmd.Parameters["@sTaikhoan"].Value = tk;
                cmd.Parameters["@sMatKhau"].Value = mk;
                cmd.Parameters["@iMaCB"].Value = nhanVien_DAO.max_iMaCB("FK_iMaCB");
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            public static void update_NV(String[] data, string maCB)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_update_nhanvien", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sTenCB", data[0]);
                cmd.Parameters.AddWithValue("@sNgaySinh", data[1]);
                cmd.Parameters.AddWithValue("@sGioiTinh", data[2]);
                cmd.Parameters.AddWithValue("@sCMT", data[3]);
                cmd.Parameters.AddWithValue("@sEmail", data[4]);
                cmd.Parameters.AddWithValue("@sSDT", data[5]);
                cmd.Parameters.AddWithValue("@iMaCanBo", maCB);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            public static String get_tenDangNhapTheoMa(string manv)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_tenDangNhapTheoMa", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FK_iMaCB", manv);
                SqlDataReader dar = cmd.ExecuteReader();
                while (dar.Read())
                {
                    return dar["sTenDangNhap"].ToString();
                }
                Conn.Close();
                return null;
            }

            public static String get_maNhanVienTheoTenDN(string sTenDangNhap)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_maNhanVienTheoTen", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sTenDangNhap", sTenDangNhap);
                SqlDataReader dar = cmd.ExecuteReader();
                while (dar.Read())
                {
                    return dar["FK_iMaCB"].ToString();
                }
                Conn.Close();
                return null;
            }

            public static void update_passTheoTenTK(string tenTK, string matKhau)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_update_passTheoTenDN", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sTenDangNhap", tenTK);
                cmd.Parameters.AddWithValue("@sMatKhau", matKhau);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }

            public void update_status_tk(int maCB, string trangthai)
            {
                SqlConnection Conn = SqlConnectionData.connect();
                SqlCommand cmd = new SqlCommand("sp_change_status", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iMaCanBo", maCB);
                cmd.Parameters.AddWithValue("@sTrangthai", trangthai);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }

    }
}
