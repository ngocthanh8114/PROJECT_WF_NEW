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
using Home.FrmCon;
using Microsoft.VisualBasic;
using System.Collections;



namespace Home.DuLieu
{
    
    internal class XuLiDuLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string strconn = "Data Source=.;Initial Catalog=BanXeMay;Persist Security Info=True;User ID=sa;Password=123";
        SqlConnection conn = null;

        public void Connection_CSDL()
        {
            conn = new SqlConnection(strconn);
            conn.Open();
        }
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
        public void DatHang(string MaSP, string TenSP, decimal Gia, int SoLuong, Image Anh)
        {
            kn.myConnect();
            if(kiemTraDonHang(MaSP))
            {
                string sql = "select SoLuong from DonHang_1 where TenTaiKhoan= @TenTaiKhoan and MaSP= @MaSP ";
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
                string sql = "INSERT INTO DonHang_1 (TenTaiKhoan, MaSP, TenSP, Gia, SoLuong, Anh, TrangThai) VALUES (@TenTaiKhoan, @MaSP, @TenSP, @Gia, @SoLuong, @Anh, 0)";
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
        
        }
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
            string lenh = "select * from DonHang_1 where TenTaiKhoan= @TenTaiKhoan and TrangThai not like 2";
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
            SqlParameter sqlParameter = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
            sqlParameter.Value = tenSP;
            sqlCmd.Parameters.Add(sqlParameter);
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
            return Regex.IsMatch(em, @"^[\w.]{3,50}@gmail.com(.vn|)$");
        }
        public bool CheckAccount(string ac)
        {
            return !Regex.IsMatch(ac, @"[^\w]");
        }
        public bool checkSDT(string sdt) 
        {
            return Regex.IsMatch(sdt, @"^[0-9]{10,11}$");
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
                    SqlCommand cmd = new SqlCommand(sql, kn.con);

                    SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
                    sqlParameter0.Value = TenTaiKhoan;
                    cmd.Parameters.Add(sqlParameter0);

                    SqlParameter sqlParameter1 = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50);
                    sqlParameter1.Value = MatKhau;
                    cmd.Parameters.Add(sqlParameter1);

                    SqlParameter sqlParameter2 = new SqlParameter("@TenNguoiDung", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = TenNguoiDung;
                    cmd.Parameters.Add(sqlParameter2);

                    SqlParameter sqlParameter3 = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                    sqlParameter3.Value = Email;
                    cmd.Parameters.Add(sqlParameter3);

                    SqlParameter sqlParameter4 = new SqlParameter("@SoDienThoai", SqlDbType.NVarChar, 50);
                    sqlParameter4.Value = SoDienThoai;
                    cmd.Parameters.Add(sqlParameter4);

                    SqlParameter sqlParameter5 = new SqlParameter("@PhanQuyen", SqlDbType.NVarChar, 50);
                    sqlParameter5.Value = PhanQuyen;
                    cmd.Parameters.Add(sqlParameter5);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        FrmThongBao frmThongBao = new FrmThongBao();
                        frmThongBao.hienThiThongBao("Đăng ký tài khoản thành công");
                        frmThongBao.Show();
                        dangKyThanhCong = true;
                    }

                }
                catch
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Tên tài khoản đã được sử dụng");
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
            SqlParameter sqlParameter = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
            sqlParameter.Value = tenSP;
            cmd.Parameters.Add(sqlParameter);
            cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            cmd.ExecuteNonQuery();
        }

        public void DaMuaHang()
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 2 where TrangThai = 1";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
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


        public void turnTongTien()
        {
            kn.myConnect();
            string sql = "update DonHang_1 set TrangThai = 1 where TenTaiKhoan = @TenTK ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);
            cmd.ExecuteNonQuery();
        }

        public void MuaHang(string TenKH, string Email, string SoDienThoai, string DiaChi, string LoiNhan, string TongTienHang, string PhiVanChuyen, string TongThanhToan)
        {
            kn.myConnect();
            string sql = "UPDATE ThongTinDH set TenTaiKhoan = @TenTaiKhoan, TenKH = @TenKH, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, LoiNhan = @LoiNhan, TongTienHang = @TongTienHang, PhiVanChuyen = @PhiVanChuyen, TongThanhToan = @TongThanhToan where MaDH = @MaDH";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@TenKH", SqlDbType.NVarChar, 50);
            sqlParameter1.Value = TenKH;
            cmd.Parameters.Add(sqlParameter1);

            SqlParameter sqlParameter2 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            sqlParameter2.Value = DiaChi;
            cmd.Parameters.Add(sqlParameter2);

            SqlParameter sqlParameter3 = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            sqlParameter3.Value = Email;
            cmd.Parameters.Add(sqlParameter3);

            SqlParameter sqlParameter4 = new SqlParameter("@SoDienThoai", SqlDbType.NVarChar, 50);
            sqlParameter4.Value = SoDienThoai;
            cmd.Parameters.Add(sqlParameter4);

            SqlParameter sqlParameter5 = new SqlParameter("@LoiNhan", SqlDbType.NVarChar);
            sqlParameter5.Value = LoiNhan;
            cmd.Parameters.Add(sqlParameter5);

            SqlParameter sqlParameter6 = new SqlParameter("@TongTienHang", SqlDbType.NVarChar, 50);
            sqlParameter6.Value = TongTienHang;
            cmd.Parameters.Add(sqlParameter6);

            SqlParameter sqlParameter7 = new SqlParameter("@PhiVanChuyen", SqlDbType.NVarChar, 50);
            sqlParameter7.Value = PhiVanChuyen;
            cmd.Parameters.Add(sqlParameter7);

            SqlParameter sqlParameter8 = new SqlParameter("@TongThanhToan", SqlDbType.NVarChar, 50);
            sqlParameter8.Value = TongThanhToan;
            cmd.Parameters.Add(sqlParameter8);

            SqlParameter sqlParameter9 = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameter9.Value = MaDonHangHienTai.maDH;
            cmd.Parameters.Add(sqlParameter9);

            cmd.ExecuteNonQuery();
        }

        // Lấy ra các sản phẩm đã mua
        public DataTable hangDaMua()
        {
            kn.myConnect();
            string sql = "SELECT MaSP,SoLuong FROM DonHang_1 where TrangThai = 2";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Cập nhật số lượng
        public void xoaSL(string MaSP,int SL)
        {
            kn.myConnect();
            // Trừ đi sản phẩm
            string sql = "SELECT SoLuong FROM SanPham where MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("MaSP", MaSP);
            int SLHT = (int)cmd.ExecuteScalar() - SL;

            string sql1 = "update SanPham set SoLuong = @SL where MaSP = @MaSP";
            SqlCommand cmd1 = new SqlCommand(sql1, kn.con);
            cmd1.Parameters.AddWithValue("MaSP", MaSP);
            cmd1.Parameters.AddWithValue("SL", SLHT);
            cmd1.ExecuteNonQuery();
        }
        // Xóa sản phẩm đã mua
        public void xoaDonHangDaMua()
        {
            kn.myConnect();
            string query = "delete  from DonHang_1 where TrangThai = 2";
            SqlCommand cmd = new SqlCommand(query, kn.con);
            cmd.ExecuteNonQuery();
        }
        
        //Chuyển sản phẩm qua bảng đơn hàng đã mua
        public void chuyenSP(string MaSP, int SL)
        {
            kn.myConnect();
            string sql = "INSERT INTO DonHangDaMua (TenTaiKhoan,MaSP,MaDH,SoLuong) VALUES (@TenTaiKhoan,@MaSP,@MaDH,@SL)";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NVarChar, 50);
            sqlParameter1.Value = MaSP;
            cmd.Parameters.Add(sqlParameter1);

            SqlParameter sqlParameter2 = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameter2.Value = MaDonHangHienTai.maDH;
            cmd.Parameters.Add(sqlParameter2);

            SqlParameter sqlParameter3 = new SqlParameter("@SL", SqlDbType.Int);
            sqlParameter3.Value = SL;
            cmd.Parameters.Add(sqlParameter3);
            
            cmd.ExecuteNonQuery();
        }

        // Trừ đi số lượng
        public void truSoLuongDaMua()
        {
            foreach(DataRow row in hangDaMua().Rows)
            {
                string MaSP  = row["MaSP"].ToString();
                int SL = row.Field<int>("SoLuong");
                xoaSL(MaSP,SL);
                chuyenSP(MaSP,SL);
            }    
            xoaDonHangDaMua();
        }

        //Thêm đơn hàng;
        public void themDonMua()
        {
            kn.myConnect();
            string sql = "INSERT INTO ThongTinDH (TenTaiKhoan) VALUES (NULL)";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            cmd.ExecuteNonQuery();
        }

       
        // Lấy MaDH hiện tại
        public string DonHangHienTai()
        {
            kn.myConnect();
            string sql = "SELECT MaDH from ThongTinDH where TenTaiKhoan is Null ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            string maDH = cmd.ExecuteScalar().ToString();
            return maDH;
        }

        //Kiểm tra đơn hàng có tồn tại tên TK chưa
        public bool kiemTraDonMua()
        {
            kn.myConnect();
            string sql = "SELECT count(*) from ThongTinDH where TenTaiKhoan is Null ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                return false;
            }
            return true;
        }

        /* // Chèn đơn hàng
        public void chenDonHang()
        {
            string sql = "update ThongTinDH set TenTaiKhoan = @TenTaiKhoan where TongTienHang is NULL";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            cmd.ExecuteNonQuery();
        }

        // Xóa đi đơn hàng nếu thoát mà chưa đặt
        public void loaiBoDonHang()
        {
            string sql = "update ThongTinDH set TenTaiKhoan = NULL where TongTienHang is NULL";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            cmd.ExecuteNonQuery();
        }
        */

        public bool capNhatTaiKhoan = false;
        public void CapNhatTaiKhoan(string tenNguoiDung, string email, string soDienThoai, Guna2HtmlLabel em, Guna2HtmlLabel soDT, Guna2HtmlLabel tenND)
        {
            if ((tenNguoiDung == "" || email == "" || soDienThoai == ""))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
            }
            else
            {
                if (!checkTenNguoiDung(tenNguoiDung))
                {
                    tenND.Visible = true;
                    return;
                }
                else
                {
                    tenND.Visible = false;
                }
                if (!CheckEmail(email))
                {
                    em.Visible = true;
                    return;
                }
                else
                {
                    em.Visible = false;
                }

                if (!checkSDT(soDienThoai))
                {
                    soDT.Visible = true;
                    return;
                }
                else
                {
                    soDT.Visible = false;
                }
                kn.myConnect();
                string sql = "UPDATE TaiKhoan SET TenNguoiDung = @TenND, Email = @Email, SoDienThoai = @SoDT WHERE TenTaiKhoan = @TenTK";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("TenTK", TaiKhoanDangNhap.tenTaiKhoan);
                cmd.Parameters.AddWithValue("TenND", tenNguoiDung);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("SoDT", soDienThoai);

                cmd.ExecuteNonQuery();
                TaiKhoanDangNhap.tenNguoiDung = tenNguoiDung;
                TaiKhoanDangNhap.email = email;
                TaiKhoanDangNhap.soDienThoai = soDienThoai;
                capNhatTaiKhoan = true;
                
            }
        }

        public void XoaSanPhamAdmin(string MaSP)
        {
            // Truy vấn xóa
            kn.myConnect();
            string sql = "DELETE FROM SanPham WHERE MaSP= @MaSP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaSP", MaSP);
            cmd.ExecuteNonQuery(); 
        }
        public void LoadFrmCapNhatHH(string masp, Guna2TextBox maSP, Guna2TextBox tenSP, Guna2TextBox gia, Guna2TextBox maNCC, Guna2TextBox soLuong, Guna2PictureBox Anh, Guna2TextBox maLoai)
        {
            kn.myConnect();
            string sql = "SELECT * FROM SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaSP", masp);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string idsp = reader.GetString(0);
                string name = reader.GetString(1);
                string price = reader.GetDecimal(2).ToString();
                string idncc = reader.GetString(3);
                string sl = reader.GetInt32(4).ToString();
                Image anh = ByteArrToImage((byte[])reader.GetValue(5));
                string idloai = reader.GetString(6);

                //Hiển thị
                maSP.Text = idsp.Trim();
                tenSP.Text = name.Trim();
                gia.Text = price.Trim();
                maNCC.Text = idncc.Trim();
                soLuong.Text = sl.Trim();
                Anh.Image = anh;
                maLoai.Text = idloai.Trim();
            }
            //Đóng đầu đọc
            reader.Close();
        }
        public byte[] ImageToByte(Image img)
        {
            using (Bitmap bmp = new Bitmap(img))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    bmp.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    return m.ToArray();
                }
            }
        }
        public void SuaThongTinSanPhamAdmin(string MaNCC, string TenSP, string MaLoai, string SoLuong, string Gia, string MaSP, Image hinhAnh)
        {
            // Sửa
            kn.myConnect();
            string sql = "UPDATE SanPham SET MaNCC= @MaNCC, TenSP= @TenSP, MaLoai= @MaLoai, SoLuong= @SoLuong, Gia= @Gia, HinhAnh =@HinhAnh WHERE MaSP= @MaSP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaNCC", MaNCC);
            cmd.Parameters.AddWithValue("TenSP", TenSP);
            cmd.Parameters.AddWithValue("MaLoai", MaLoai);
            cmd.Parameters.AddWithValue("SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("Gia", Gia);
            cmd.Parameters.AddWithValue("MaSP", MaSP);
            byte[] bytes = ImageToByte(hinhAnh);
            cmd.Parameters.AddWithValue("HinhAnh", bytes);
            cmd.ExecuteNonQuery();
        }
        //Nhập hàng
        
        public bool checkSo(string sdt)
        {
            return Regex.IsMatch(sdt, @"^[0-9]{1,50}$");
        }
        public bool NhapHang = false;
        public void NhapHangAdmin(string MaSP, string TenSP, string Gia,string MaNCC, string SoLuong, Image Anh, string MaLoai, Guna2HtmlLabel gia, Guna2HtmlLabel soluong)
        {
            if ((MaSP == "" || TenSP == "" || Gia == "" || MaNCC == "" || SoLuong == "" || Anh == null || MaLoai == ""))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
            }
            else
            {
                if (!checkSo(SoLuong))
                {
                    soluong.Visible = true;
                    return;
                }
                else
                {
                    soluong.Visible = false;
                }
                if (!checkSo(Gia))
                {
                    gia.Visible = true;
                    return;
                }
                else
                {
                    gia.Visible = false;
                }
                kn.myConnect();
                try
                {
                    string sql = "INSERT INTO SanPham VALUES (@MaSP, @TenSP, @Gia, @MaNCC, @SoLuong, @Anh, @MaLoai)";
                    SqlCommand cmd = kn.con.CreateCommand();
                    cmd.CommandText = sql;

                    SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
                    sqlParameter1.Value = MaSP;
                    cmd.Parameters.Add(sqlParameter1);

                    SqlParameter sqlParameter2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = TenSP;
                    cmd.Parameters.Add(sqlParameter2);

                    SqlParameter sqlParameter3 = new SqlParameter("@Gia", SqlDbType.Decimal, 18);
                    sqlParameter3.Value = Gia;
                    cmd.Parameters.Add(sqlParameter3);

                    SqlParameter sqlParameter4 = new SqlParameter("@MaNCC", SqlDbType.NChar, 10);
                    sqlParameter4.Value = MaNCC;
                    cmd.Parameters.Add(sqlParameter4);

                    SqlParameter sqlParameter5 = new SqlParameter("@SoLuong", SqlDbType.Int);
                    sqlParameter5.Value = SoLuong;
                    cmd.Parameters.Add(sqlParameter5);

                    byte[] bytes = ImageToByte(Anh);
                    SqlParameter sqlParameter6 = new SqlParameter("@Anh", SqlDbType.VarBinary, bytes.Length);
                    sqlParameter6.Value = bytes;
                    cmd.Parameters.Add(sqlParameter6);

                    SqlParameter sqlParameter7 = new SqlParameter("@MaLoai", SqlDbType.NChar, 10);
                    sqlParameter7.Value = MaLoai;
                    cmd.Parameters.Add(sqlParameter7);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        FrmThongBao frmThongBao = new FrmThongBao();
                        frmThongBao.hienThiThongBao("Thêm hàng thành công!");
                        frmThongBao.Show();
                        NhapHang = true;
                    }
                }
                catch
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại dữ liệu nhập vào!");
                    frmBaoLoi.Show();
                    NhapHang = false;
                }
            }
        }

    }
}
