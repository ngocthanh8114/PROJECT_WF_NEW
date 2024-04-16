using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Security.Cryptography;
using Home;
using Home.FrmCon.FrmHienThi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Media.Media3D;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;


namespace Home.DuLieu
{
    
    internal class XuLiDuLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        string strconn = "Data Source=LAPTOP-IGR3NG0G\\SQLEXPRESS;Initial Catalog=BanXeMay;Integrated Security=True;Encrypt=False";

        SqlDataAdapter da = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        DataSet ds = null;

        public void Connection_CSDL()
        {
            conn = new SqlConnection(strconn);
            conn.Open();
        }
        //------------------------------------------NgocThanh---------------------------------------------

        public string xuLiMaNCC(string maNCC)
        {
            kn.myConnect();
            string lenh1 = "SELECT TenNCC FROM NCC WHERE MaNCC = @MaNCC";
            SqlCommand cmd1 = kn.con.CreateCommand();
            cmd1.CommandText = lenh1;
            SqlParameter sqlParameter = new SqlParameter("@MaNCC", SqlDbType.NChar, 10);
            sqlParameter.Value = maNCC;
            cmd1.Parameters.Add(sqlParameter);
            string nCC = cmd1.ExecuteScalar().ToString();

            cmd1.Dispose();
            return nCC;
        }

        public string xuLiMaLoai(string LoaiSP)
        {
            kn.myConnect();
            string lenh1 = "SELECT MaLoai FROM LoaiSP WHERE LoaiSP = @LoaiSP";
            SqlCommand cmd1 = kn.con.CreateCommand();
            cmd1.CommandText = lenh1;
            SqlParameter sqlParameter = new SqlParameter("@LoaiSP", SqlDbType.NVarChar, 50);
            sqlParameter.Value = LoaiSP;
            cmd1.Parameters.Add(sqlParameter);
            string maLoai = cmd1.ExecuteScalar().ToString();

            cmd1.Dispose();
            return maLoai;
        }

        public Image ByteArrToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        public DataTable doDuLieu(string MaLoai)
        {
            kn.myConnect();
            string lenh = "select * from SanPham where MaLoai = @Maloai";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;
            SqlParameter sqlParameter = new SqlParameter("@MaLoai", SqlDbType.NChar, 10);
            sqlParameter.Value = MaLoai;
            cmd.Parameters.Add(sqlParameter);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable themLoaiSP()
        {
            kn.myConnect();
            string lenh = "SELECT LoaiSP FROM [LoaiSP] ";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Kiểm tra đơn hàng
        public bool kiemTraDonHang(string MaSP)
        {
            string sql = "select count(*) from DonHang_1 where TenTaiKhoan= @TenTaiKhoan and MaSP= @MaSP";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = sql;
            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NChar, 10);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
             cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
            sqlParameter1.Value = MaSP;
            cmd.Parameters.Add(sqlParameter1);

            int i = (int)cmd.ExecuteScalar();
            if(i>0) return true;
            return false;
        }
        public void themSL(int SL,string MaSP)
        {
            string sql = "update DonHang_1 set SoLuong = @SL where TenTaiKhoan= @TenTaiKhoan and MaSP= @MaSP";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = sql;

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NChar, 10);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
            sqlParameter1.Value = MaSP;
            cmd.Parameters.Add(sqlParameter1);

            SqlParameter sqlParameter4 = new SqlParameter("@SL", SqlDbType.Int);
            sqlParameter4.Value = SL;
            cmd.Parameters.Add(sqlParameter4);

            cmd.ExecuteNonQuery();
        }

        // Tính số lượng sp hiện có
        public int soLuongSP(string MaSP)
        {
            string sql = "SELECT SoLuong FROM SanPham where MaSP = @MaSP";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = sql;

            SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
            sqlParameter1.Value = MaSP;
            cmd.Parameters.Add(sqlParameter1);
            return (int)cmd.ExecuteScalar();
        }

        //------------------------------------------NgocThanh---------------------------------------------
        public void DatHang(string MaSP, string TenSP, decimal Gia, int SoLuong, Image Anh)
        {
            kn.myConnect();
            if(kiemTraDonHang(MaSP))
            {
                string sql = "select SoLuong from DonHang_1 where TenTaiKhoan= @TenTaiKhoan and MaSP= @MaSP";
                SqlCommand cmd = kn.con.CreateCommand();
                cmd.CommandText = sql;

                SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NChar, 10);
                sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
                cmd.Parameters.Add(sqlParameter0);

                SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
                sqlParameter1.Value = MaSP;
                cmd.Parameters.Add(sqlParameter1);

                int SL = (int)cmd.ExecuteScalar() + SoLuong;
                if(SL > soLuongSP(MaSP))
                {
                    
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Số lượng sản phẩm vượt quá mức cho phép");
                    frmBaoLoi.Show();
                    return;
                }
                else
                {
                    FrmThongBao frmThongBao = new FrmThongBao();
                    frmThongBao.Show();
                    themSL(SL, MaSP);
                }    
                
            }   
            else 
            {
                string sql = "INSERT INTO DonHang_1 (TenTaiKhoan, MaSP, TenSP, Gia, SoLuong, Anh) VALUES (@TenTaiKhoan, @MaSP, @TenSP, @Gia, @SoLuong, @Anh)";
                SqlCommand cmd = kn.con.CreateCommand();
                cmd.CommandText = sql;

                SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NChar, 10);
                sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
                cmd.Parameters.Add(sqlParameter0);

                SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
                sqlParameter1.Value = MaSP;
                cmd.Parameters.Add(sqlParameter1);

                SqlParameter sqlParameter2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
                sqlParameter2.Value = TenSP;
                cmd.Parameters.Add(sqlParameter2);

                SqlParameter sqlParameter3 = new SqlParameter("@Gia", SqlDbType.Decimal, 18);
                sqlParameter3.Value = Gia;
                cmd.Parameters.Add(sqlParameter3);

                SqlParameter sqlParameter4 = new SqlParameter("@SoLuong", SqlDbType.Int);
                sqlParameter4.Value = SoLuong;
                cmd.Parameters.Add(sqlParameter4);

                byte[] bytes = ImageToByteArray(Anh);
                SqlParameter sqlParameter5 = new SqlParameter("@Anh", bytes);
                cmd.Parameters.Add(sqlParameter5);
                if (SoLuong > soLuongSP(MaSP))
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Số lượng sản phẩm vượt quá mức cho phép");
                    frmBaoLoi.Show();
                    return;
                }
                else 
                {
                    FrmThongBao frmThongBao = new FrmThongBao();
                    frmThongBao.Show();
                    cmd.ExecuteNonQuery();
                }
                
            }
            

        }

        public DataTable layThongTinTK(string taikhoan, string matkhau)
        {
            string sql = "select * from TaiKhoan where TenTaiKhoan= @TenTK and MatKhau= @MatKhau";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@TenTK", taikhoan);
            command.Parameters.AddWithValue("@MatKhau", matkhau);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public void DangNhap(string taikhoan, string matkhau, Form Home)
        {
            string sql = "select PhanQuyen from TaiKhoan where TenTaiKhoan= @TenTK and MatKhau= @MatKhau";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@TenTK", taikhoan);
            command.Parameters.AddWithValue("@MatKhau", matkhau);
            // Thử thực hiện truy vấn
            object result = command.ExecuteScalar();
            if (result != null)
            {
                string PhanQuyen = result.ToString();
                if (PhanQuyen == "user")
                {
                    Home.Show();
                    
                }
                else if (PhanQuyen == "admin")
                {
                    //Chưa có formAdmin...làm sau
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.Show();

                }
            }

            // Tạo và thực thi câu truy vấn
           
            //RESET TB
            taikhoan = matkhau = "";
        
        }
        //------------------------------------------NgocThanh---------------------------------------------

        /*    public DataTable themSanPham(string MaLoai)
            {
                kn.myConnect();
                string lenh = "select * from SanPham where MaLoai = @Maloai";
                SqlCommand cmd = kn.con.CreateCommand();
                cmd.CommandText = lenh;
                SqlParameter sqlParameter = new SqlParameter("@MaLoai", SqlDbType.NChar, 10);
                sqlParameter.Value = MaLoai;
                cmd.Parameters.Add(sqlParameter);

            }*/

        public DataTable doDuLieu()
        {
            kn.myConnect();
            string lenh = "select * from DonHang_1 where TenTaiKhoan= @TenTaiKhoan";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;
            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NChar, 10);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        public void xoaDonHang(string tenSP)
        {
            kn.myConnect();
            string query = "delete  from DonHang_1 where tenSP = @TenSP and TenTaiKhoan = @TenTK";
            SqlCommand sqlCmd = new SqlCommand(query, conn);
            sqlCmd.Parameters.AddWithValue("TenSP", tenSP);
            sqlCmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);
            sqlCmd.ExecuteNonQuery();
        }

        public DataTable doDuLieu_TimKiem(string TenSP)
        {
            kn.myConnect();
            string sql = "SELECT TenSP, Gia, SoLuong, Anh FROM DonHang_1 WHERE TenSP LIKE @TenSP AND TenTaiKhoan = @TenTK";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("@TenSP", "%" + TenSP + "%");
            cmd.Parameters.AddWithValue("@TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CheckEmail(string em) //Check email
        {
            return Regex.IsMatch(em, @"^[\w.]{3,20}@gmail.com(.vn|)$");
        }
        public bool CheckAccount(string ac)
        {
            return !Regex.IsMatch(ac, @"[^\w]");
        }
        public bool checkSDT(string sdt) 
        {
            return Regex.IsMatch(sdt, @"^[0-9]{6,24}$");
        }
        public bool checkTenNguoiDung(string tnd)
        {
            return Regex.IsMatch(tnd, @"^[\p{L}\s]{1,50}$");
        }
        public bool dangKyThanhCong = false;
        public void DangKyTK(string TenTaiKhoan, string MatKhau, string xnMatKhau, string TenNguoiDung, string Email, string SoDienThoai, Guna2HtmlLabel taiKhoan, Guna2HtmlLabel matKhau, Guna2HtmlLabel email, Guna2HtmlLabel sdt, Guna2HtmlLabel tnd)
        {
            if ((TenTaiKhoan == "" || MatKhau == "" || TenNguoiDung == "" || Email == "" || SoDienThoai == ""))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
            }
            else
            {
                if (!CheckAccount(TenTaiKhoan))
                {
                    taiKhoan.Visible = true;
                    return;
                }
                else
                {
                    taiKhoan.Visible = false;
                }
                if (MatKhau != xnMatKhau)
                {
                    matKhau.Visible = true;
                    return;
                }
                else
                {
                    matKhau.Visible = false;
                }
                if (!checkTenNguoiDung(TenNguoiDung))
                {
                    tnd.Visible = true;
                    return;
                }
                else
                {
                    tnd.Visible = false;
                }
                if (!CheckEmail(Email))
                {
                    email.Visible = true;
                    return;
                }
                else
                {
                    email.Visible = false;
                }

                if (!checkSDT(SoDienThoai))
                {
                    sdt.Visible = true;
                    return;
                }
                else
                {
                    sdt.Visible = false;
                }
                try
                {
                    string PhanQuyen = "user";
                    kn.myConnect();
                    string sql = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, TenNguoiDung, Email, SoDienThoai, PhanQuyen) VALUES (@TenTaiKhoan, @MatKhau, @TenNguoiDung, @Email, @SoDienThoai, @PhanQuyen)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("TenTaiKhoan", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("TenNguoiDung", TenNguoiDung);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("SoDienThoai", SoDienThoai);
                    cmd.Parameters.AddWithValue("PhanQuyen", PhanQuyen);
                   
                    FrmThongBao frmThongBao = new FrmThongBao();
                    frmThongBao.hienThiThongBao("Đăng ký tài khoản thành công");
                    frmThongBao.Show();
                    dangKyThanhCong = true;
                    
                }
                catch
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Tên tài khoản đã được sử dụng!");
                    frmBaoLoi.Show();
                    dangKyThanhCong = false;
                }
            }
        }
        public void LayLaiMatKhau(string Email, Guna2HtmlLabel matKhau2, Guna2HtmlLabel tenTaiKhoan)
        {
            kn.myConnect();
            string sql = "Select MatKhau, TenTaiKhoan from TaiKhoan where Email = @Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", Email);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy mật khẩu và tên tài khoản từ dữ liệu đọc được
                    string matKhau = reader["MatKhau"].ToString();
                    string TenTaiKhoan = reader["TenTaiKhoan"].ToString();

                    tenTaiKhoan.ForeColor = Color.Blue;
                    matKhau2.ForeColor = Color.Blue;

                    matKhau2.Text = "Mật Khẩu: " + matKhau;
                    tenTaiKhoan.Text = "Tên tài khoản: " + TenTaiKhoan;
                    matKhau2.Visible = true;
                    tenTaiKhoan.Visible = true;
                }
                else
                {
                    tenTaiKhoan.ForeColor = Color.Red;
                    tenTaiKhoan.Text = "Email chưa được đăng kí";
                    matKhau2.Visible = false;
                    tenTaiKhoan.Visible = true;
                }

                reader.Close(); // Đóng đối tượng SqlDataReader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                kn.myClose(); // Đóng kết nối đến cơ sở dữ liệu
            }
        }
        public void DangDatHang(string tenSP)
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 1 where tenSP = @TenSP and TenTaiKhoan = @TenTK";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("TenSP", tenSP);
            cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            cmd.ExecuteNonQuery();
        }

        public void BoDatHang(string tenSP)
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 0 where tenSP = @TenSP and TenTaiKhoan = @TenTK";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("TenSP", tenSP);
            cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            cmd.ExecuteNonQuery();
        }

        public void MuaHang(string tenSP)
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 2 where tenSP = @TenSP and TenTaiKhoan = @TenTK";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("TenSP", tenSP);
            cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            cmd.ExecuteNonQuery();
        }
        public DataTable capNhatDatHang()
        {
            kn.myConnect();
            string sql = "SELECT Gia, SoLuong, Gia*SoLuong as TongTien FROM DonHang_1 group by Gia,SoLuong,TrangThai having TrangThai = 1";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public decimal tinhTongTien()
        {
            decimal result = 0;
            foreach (DataRow row in capNhatDatHang().Rows)
            {
                result += row.Field<decimal>("TongTien");
            }
            return result;
        }

        public decimal tinhSP()
        {
            decimal result = 0;
            foreach (DataRow row in capNhatDatHang().Rows)
            {
                result += row.Field<int>("SoLuong");
            }
            return result;
        }

        public void resetTongTien()
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 0 ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            
            cmd.ExecuteNonQuery();
        }
    }
}
