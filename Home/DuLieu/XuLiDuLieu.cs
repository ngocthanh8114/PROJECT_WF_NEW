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
using System.Data.Common;



namespace Home.DuLieu
{
    
    internal class XuLiDuLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();


        static string strconn = "Data Source=.;Initial Catalog=BanXeMay;User ID=sa;Password=123;Encrypt=False";

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
        public DataTable GetOrderInfoByDateRange(DateTime startDate, DateTime endDate)
        {
            kn.myConnect();
            DataTable dt = new DataTable();
            string query = @"SELECT THD.MaDH AS 'Mã Đơn Hàng', THD.TongTienHang AS 'Tổng tiền', THD.NgayDH AS 'Ngày mua hàng'
                     FROM dbo.ThongTinDH THD
                     WHERE THD.NgayDH >= @StartDate AND THD.NgayDH <= @EndDate";

            SqlCommand cmd = new SqlCommand(query, kn.con);
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
        public decimal CalculateTotalThanhTienTungSP(string tenSP, DateTime startDate, DateTime endDate)
        {
            kn.myConnect();
            decimal totalThànhTiền = 0;
            string query = @"SELECT DH.MaDH AS 'Mã Đơn Hàng', 
                                           SP.TenSP AS 'Tên Sản Phẩm', 
                                           DH.SoLuong AS 'Số Lượng', 
                                           SP.Gia AS 'Giá', 
                                           SP.Gia * DH.SoLuong AS 'Thành Tiền', 
                                           TT.NgayDH AS 'Ngày Mua'
                                    FROM dbo.DonHangDaMua DH
                                    INNER JOIN dbo.SanPham SP ON DH.MaSP = SP.MaSP
                                    INNER JOIN dbo.ThongTinDH TT ON DH.MaDH = TT.MaDH
                                    WHERE SP.TenSP = @TenSP AND TT.NgayDH BETWEEN @StartDate AND @EndDate";
            SqlCommand cmd = new SqlCommand(query, kn.con);
            cmd.Parameters.AddWithValue("@TenSP", tenSP);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                decimal thànhTiền = Convert.ToDecimal(reader["Thành Tiền"]);
                totalThànhTiền += thànhTiền;
            }
            reader.Close();
            return totalThànhTiền;
        }
        /* public decimal CalculateTotalTongTienAllSP(DateTime startDate, DateTime endDate)
         {
            *//* kn.myConnect();
             decimal totalTongTien = 0;

             string query = @"SELECT THD.TongTienHang
                                      FROM dbo.ThongTinDH THD
                                      WHERE THD.NgayDH >= @StartDate AND THD.NgayDH <= @EndDate";

             SqlCommand command = new SqlCommand(query, kn.con);
             command.Parameters.AddWithValue("@StartDate", startDate);
             command.Parameters.AddWithValue("@EndDate", endDate);

             SqlDataReader reader = command.ExecuteReader();

             while (reader.Read())
             {
                 // Đọc giá trị của cột 'Tổng tiền' và cộng dồn vào tổng
                 decimal tongTien = Convert.ToDecimal(reader["TongTienHang"]);
                 totalTongTien += tongTien;
             }

             reader.Close();
             return totalTongTien;*//*
         }*/
        public DataTable GetOrderDetailsByProductAndDate(string tenSP, DateTime startDate, DateTime endDate)
        {
            try
            {
                kn.Connection(); 
                string query = @"SELECT DH.MaDH AS 'Mã Đơn Hàng', SP.TenSP AS 'Tên Sản Phẩm',
                               DH.SoLuong AS 'Số Lượng', SP.Gia AS 'Giá', 
                               SP.Gia * DH.SoLuong AS 'Thành Tiền', 
                               TT.NgayDH AS 'Ngày Mua'
                               FROM dbo.DonHangDaMua DH
                               INNER JOIN dbo.SanPham SP ON DH.MaSP = SP.MaSP
                               INNER JOIN dbo.ThongTinDH TT ON DH.MaDH = TT.MaDH
                               WHERE SP.TenSP = @TenSP AND TT.NgayDH BETWEEN @StartDate AND @EndDate";

                SqlCommand cmd = new SqlCommand(query, kn.con);
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); 
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                kn.myClose(); 
            }
        }

        public void xuLiTenSP(Guna2ComboBox LoaiSP)
        {
            try
            {
                kn.Connection();

                string query = "SELECT DISTINCT SP.TenSP, SP.MaSP " +
                               "FROM dbo.DonHangDaMua DH " +
                               "INNER JOIN dbo.SanPham SP ON DH.MaSP = SP.MaSP";

                SqlCommand cmd = new SqlCommand(query, kn.con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "SanPham");

                DataTable dt = ds.Tables["SanPham"];

                DataRow allRow = dt.NewRow();
                allRow["TenSP"] = "Tất cả";
                allRow["MaSP"] = -1; 

                dt.Rows.InsertAt(allRow, 0);

                LoaiSP.DataSource = dt;

                LoaiSP.DisplayMember = "TenSP";

                LoaiSP.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                kn.myClose();
            }
        }

        public DataTable LocSanPhamTheoLoaiVaGia(string LoaiSP, decimal minPrice, decimal maxPrice)
        {
            kn.myConnect();
            string lenh = "SELECT * FROM SANPHAM WHERE  MaLoai = @LoaiSP AND Gia BETWEEN @MinPrice AND @MaxPrice";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;
            SqlParameter sqlParameter = new SqlParameter("@LoaiSP", SqlDbType.NVarChar, 50);
            sqlParameter.Value = LoaiSP;
            cmd.Parameters.Add(sqlParameter);

            SqlParameter minParameter = new SqlParameter("@MinPrice", SqlDbType.Decimal);
            minParameter.Value = minPrice;
            cmd.Parameters.Add(minParameter);

            SqlParameter maxParameter = new SqlParameter("@MaxPrice", SqlDbType.Decimal);
            maxParameter.Value = maxPrice;
            cmd.Parameters.Add(maxParameter);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

      /*  public DataTable TimKiemSanPham(string TenSP)
        {
            kn.myConnect();
            string lenh = "SELECT * FROM SANPHAM WHERE TenSP LIKE @TenSP";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;
            SqlParameter sqlParameter = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
            sqlParameter.Value = '%' + TenSP + '%';
            cmd.Parameters.Add(sqlParameter);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
*/
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
        public int KiemTraSoLuongSP(string TenSP)
        {
            kn.myConnect();

            string sql = "SELECT SoLuong FROM SanPham WHERE TenSP = @TenSP";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = sql;

            // Thêm tham số @TenSP vào câu lệnh SQL
            SqlParameter sqlParameter1 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
            sqlParameter1.Value = TenSP;
            cmd.Parameters.Add(sqlParameter1);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result;
            }
            else
            {
                return -1;
            }

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

        public void MuaHang(string TenKH, string Email, string SoDienThoai, string DiaChi, string LoiNhan, decimal TongTienHang, decimal PhiVanChuyen, decimal TongThanhToan, DateTime NgayMua)
        {
            kn.myConnect();
            string sql = "UPDATE ThongTinDH set TenTaiKhoan = @TenTaiKhoan, TenKhachHang = @TenKH, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, LoiNhan = @LoiNhan, TongTienHang = @TongTienHang, PhiVanChuyen = @PhiVanChuyen, TongThanhToan = @TongThanhToan, NgayDH = @NgayMua where MaDH = @MaDH";
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

            SqlParameter sqlParameter6 = new SqlParameter("@TongTienHang", SqlDbType.Decimal);
            sqlParameter6.Value = TongTienHang;
            cmd.Parameters.Add(sqlParameter6);

            SqlParameter sqlParameter7 = new SqlParameter("@PhiVanChuyen", SqlDbType.Decimal);
            sqlParameter7.Value = PhiVanChuyen;
            cmd.Parameters.Add(sqlParameter7);

            SqlParameter sqlParameter8 = new SqlParameter("@TongThanhToan", SqlDbType.Decimal);
            sqlParameter8.Value = TongThanhToan;
            cmd.Parameters.Add(sqlParameter8);

            SqlParameter sqlParameter9 = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameter9.Value = MaDonHangHienTai.maDH;
            cmd.Parameters.Add(sqlParameter9);

            SqlParameter sqlParameter10 = new SqlParameter("@NgayMua", SqlDbType.DateTime);
            sqlParameter10.Value = NgayMua;
            cmd.Parameters.Add(sqlParameter10);

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
        public void LoadMaNCC(Guna2ComboBox maNCC)
        {
            kn.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NCC", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "NCC");
            maNCC.DataSource = ds.Tables["NCC"];
            maNCC.DisplayMember = "TenNCC";
            maNCC.ValueMember = "MaNCC";
        }
        public void LoadMaLoai(Guna2ComboBox maLoai)
        {
            kn.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiSP", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiSP");
            maLoai.DataSource = ds.Tables["LoaiSP"];
            maLoai.DisplayMember = "LoaiSP";
            maLoai.ValueMember = "MaLoai";
        }
        public void LoadFrmCapNhatHH(string masp, Guna2TextBox maSP, Guna2TextBox tenSP, Guna2TextBox gia, Guna2TextBox soLuong, Guna2PictureBox Anh)
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
                string sl = reader.GetInt32(4).ToString();
                Image anh = ByteArrToImage((byte[])reader.GetValue(5));

                //Hiển thị
                maSP.Text = idsp.Trim();
                tenSP.Text = name.Trim();
                gia.Text = price.Trim();
                soLuong.Text = sl.Trim();
                Anh.Image = anh;
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
        public bool SuaHang = false;
        //Sửa sản phẩm
        public void SuaThongTinSanPhamAdmin(string MaNCC, string TenSP, string MaLoai, int SoLuongCu,int SoLuongMoi, string Gia, string MaSP, Image hinhAnh, DateTime ngaynhaphang)
        {
            if(MaNCC == "" || TenSP == "" || MaLoai == "" || SoLuongCu.ToString() == "" || Gia == "" || hinhAnh == null)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
            }
            else
            {
                // Sửa
                kn.myConnect();
                string sql = "UPDATE SanPham SET MaNCC= @MaNCC, TenSP= @TenSP, MaLoai= @MaLoai, SoLuong= @SoLuong, Gia= @Gia, HinhAnh =@HinhAnh WHERE MaSP= @MaSP";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaNCC", MaNCC);
                cmd.Parameters.AddWithValue("TenSP", TenSP);
                cmd.Parameters.AddWithValue("MaLoai", MaLoai);
                cmd.Parameters.AddWithValue("SoLuong", SoLuongCu);
                cmd.Parameters.AddWithValue("Gia", Gia);
                cmd.Parameters.AddWithValue("MaSP", MaSP);
                byte[] bytes = ImageToByte(hinhAnh);
                cmd.Parameters.AddWithValue("HinhAnh", bytes);
                cmd.ExecuteNonQuery();

                //---------------------------------------------


                string selectSql = "SELECT COUNT(*) FROM NhapHang WHERE MaSP = @MaSP";
                SqlCommand selectCmd = new SqlCommand(selectSql, conn);
                selectCmd.Parameters.AddWithValue("MaSP", MaSP);
                int count = (int)selectCmd.ExecuteScalar();

                if (count > 0)
                {
                    // MaSP đã tồn tại, thực hiện UPDATE thay vì INSERT
                    string updateSql = "UPDATE NhapHang SET TenSP = @TenSP, Gia = @Gia, MaNCC = @MaNCC, SoLuong = @SoLuong, HinhAnh = @HinhAnh, MaLoai = @MaLoai, NgayNhapHang = @NgayNhapHang WHERE MaSP = @MaSP";
                    SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("TenSP", TenSP);
                    updateCmd.Parameters.AddWithValue("Gia", Gia);
                    updateCmd.Parameters.AddWithValue("MaNCC", MaNCC);
                    updateCmd.Parameters.AddWithValue("SoLuong", SoLuongMoi);
                    byte[] byte1 = ImageToByte(hinhAnh);
                    updateCmd.Parameters.AddWithValue("HinhAnh", byte1);
                    updateCmd.Parameters.AddWithValue("MaLoai", MaLoai);
                    updateCmd.Parameters.AddWithValue("NgayNhapHang", ngaynhaphang);
                    updateCmd.Parameters.AddWithValue("MaSP", MaSP);

                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // MaSP chưa tồn tại, thực hiện INSERT
                    string insertSql = "INSERT INTO NhapHang VALUES (@MaSP, @TenSP, @Gia, @MaNCC, @SoLuong, @HinhAnh, @MaLoai, @NgayNhapHang)";
                    SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("MaSP", MaSP);
                    insertCmd.Parameters.AddWithValue("TenSP", TenSP);
                    insertCmd.Parameters.AddWithValue("Gia", Gia);
                    insertCmd.Parameters.AddWithValue("MaNCC", MaNCC);
                    insertCmd.Parameters.AddWithValue("SoLuong", SoLuongMoi);
                    byte[] byte1 = ImageToByte(hinhAnh);
                    insertCmd.Parameters.AddWithValue("HinhAnh", byte1);
                    insertCmd.Parameters.AddWithValue("MaLoai", MaLoai);
                    insertCmd.Parameters.AddWithValue("NgayNhapHang", ngaynhaphang);

                    insertCmd.ExecuteNonQuery();
                }

                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Sửa thông tin thành công");
                frmThongBao.Show();
                SuaHang = true;
            }
        }
        // Lấy Số lượng của sản phẩm cũ
        public int LaySoLuong(string maSP)
        {
            int soLuong = 0;
            string sql = "SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP";

            using (SqlConnection connection = new SqlConnection(strconn))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", maSP);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        soLuong = Convert.ToInt32(result);
                    }
                }
            }

            return soLuong;
        }
        //Nhập hàng

        public bool checkSo(string sdt)
        {
            return Regex.IsMatch(sdt, @"^[0-9]{1,50}$");
        }
        public bool NhapHang = false;
        public void NhapHangAdmin(string MaSP, string TenSP, string Gia,string MaNCC, string SoLuong, Image Anh, string MaLoai, Guna2HtmlLabel gia, Guna2HtmlLabel soluong, DateTime ngaynhaphang)
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
                    string sql1 = "INSERT INTO SanPham VALUES (@MaSP, @TenSP, @Gia, @MaNCC, @SoLuong, @HinhAnh, @MaLoai)";
                    SqlCommand cmd1 = kn.con.CreateCommand();
                    cmd1.CommandText = sql1;

                    SqlParameter sqlParameter1 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
                    sqlParameter1.Value = MaSP;
                    cmd1.Parameters.Add(sqlParameter1);

                    SqlParameter sqlParameter2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
                    sqlParameter2.Value = TenSP;
                    cmd1.Parameters.Add(sqlParameter2);

                    SqlParameter sqlParameter3 = new SqlParameter("@Gia", SqlDbType.Decimal, 18);
                    sqlParameter3.Value = Gia;
                    cmd1.Parameters.Add(sqlParameter3);

                    SqlParameter sqlParameter4 = new SqlParameter("@MaNCC", SqlDbType.NChar, 10);
                    sqlParameter4.Value = MaNCC;
                    cmd1.Parameters.Add(sqlParameter4);

                    SqlParameter sqlParameter5 = new SqlParameter("@SoLuong", SqlDbType.Int);
                    sqlParameter5.Value = SoLuong;
                    cmd1.Parameters.Add(sqlParameter5);

                    byte[] bytes = ImageToByte(Anh);
                    SqlParameter sqlParameter6 = new SqlParameter("@HinhAnh", SqlDbType.VarBinary, bytes.Length);
                    sqlParameter6.Value = bytes;
                    cmd1.Parameters.Add(sqlParameter6);

                    SqlParameter sqlParameter7 = new SqlParameter("@MaLoai", SqlDbType.NChar, 10);
                    sqlParameter7.Value = MaLoai;
                    cmd1.Parameters.Add(sqlParameter7);

                    //-----------------------


                    string sql2 = "INSERT INTO NhapHang VALUES (@MaSP, @TenSP, @Gia, @MaNCC, @SoLuong, @HinhAnh, @MaLoai, @NgayNhapHang)";
                    SqlCommand cmd2 = kn.con.CreateCommand();
                    cmd2.CommandText = sql2;

                    SqlParameter sqlParameter11 = new SqlParameter("@MaSP", SqlDbType.NChar, 10);
                    sqlParameter11.Value = MaSP;
                    cmd2.Parameters.Add(sqlParameter11);

                    SqlParameter sqlParameter12 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 50);
                    sqlParameter12.Value = TenSP;
                    cmd2.Parameters.Add(sqlParameter12);

                    SqlParameter sqlParameter13 = new SqlParameter("@Gia", SqlDbType.Decimal, 18);
                    sqlParameter13.Value = Gia;
                    cmd2.Parameters.Add(sqlParameter13);

                    SqlParameter sqlParameter14 = new SqlParameter("@MaNCC", SqlDbType.NChar, 10);
                    sqlParameter14.Value = MaNCC;
                    cmd2.Parameters.Add(sqlParameter14);

                    SqlParameter sqlParameter15 = new SqlParameter("@SoLuong", SqlDbType.Int);
                    sqlParameter15.Value = SoLuong;
                    cmd2.Parameters.Add(sqlParameter15);

                    byte[] byte1 = ImageToByte(Anh);
                    SqlParameter sqlParameter16 = new SqlParameter("@HinhAnh", SqlDbType.VarBinary, byte1.Length);
                    sqlParameter16.Value = byte1;
                    cmd2.Parameters.Add(sqlParameter16);

                    SqlParameter sqlParameter17 = new SqlParameter("@MaLoai", SqlDbType.NChar, 10);
                    sqlParameter17.Value = MaLoai;
                    cmd2.Parameters.Add(sqlParameter17);

                    SqlParameter sqlParameter18 = new SqlParameter("@NgayNhapHang", SqlDbType.DateTime);
                    sqlParameter18.Value = ngaynhaphang;
                    cmd2.Parameters.Add(sqlParameter18);




                    int rowsAffected = cmd1.ExecuteNonQuery();
                    int rowsAffected2 = cmd2.ExecuteNonQuery();
                    if (rowsAffected > 0 && rowsAffected2 > 0)
                    {
                        FrmThongBao frmThongBao = new FrmThongBao();
                        frmThongBao.hienThiThongBao("Thêm hàng thành công!");
                        frmThongBao.Show();
                        NhapHang = true;
                    }
                }
                catch(Exception ex)
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Đã xảy ra lỗi: " + ex.Message);
                    frmBaoLoi.Show();
                    NhapHang = false;
                }
            }
        }

        public DataTable doDuLieuDonMua()
        {
            kn.myConnect();
            string sql = "SELECT sp.TenSP, dhdm.SoLuong, dhdm.MaDH,HinhAnh,NgayDH FROM DonHangDaMua AS dhdm JOIN ThongTinDH AS ttdh ON dhdm.MaDH = ttdh.MaDH JOIN SanPham AS sp ON sp.MaSP = dhdm.MaSP where dhdm.TenTaiKhoan = @TenTaiKhoan ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable doDuLieuDonMua(int MaDH)
        {
            kn.myConnect();
            string sql = "SELECT sp.TenSP, dhdm.SoLuong, dhdm.MaDH,HinhAnh,NgayDH FROM DonHangDaMua AS dhdm JOIN ThongTinDH AS ttdh ON dhdm.MaDH = ttdh.MaDH JOIN SanPham AS sp ON sp.MaSP = dhdm.MaSP where dhdm.TenTaiKhoan = @TenTaiKhoan and dhdm.MaDH = @MaDH ";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameter1.Value = MaDH;
            cmd.Parameters.Add(sqlParameter1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable doDiaChi()
        {
            kn.myConnect();
            string sql = "SELECT distinct * from DiaChiKhachHang where TenTaiKhoan = @TenTaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Kiểm tra địa chỉ đã tồn tại chưa
        public bool kiemTraDiaChi(string ten, string diachi, string sdt)
        {
            kn.myConnect();
            string sql = "SELECT count(*) from DiaChiKhachHang where DiaChi = @DiaChi and TenTaiKhoan = @TenTaiKhoan and SoDienThoai = @SDT and TenKhachHang = @TenKH";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameter1.Value = diachi;
            cmd.Parameters.Add(sqlParameter1);

            SqlParameter sqlParameter2 = new SqlParameter("@SDT", SqlDbType.NVarChar, 50);
            sqlParameter2.Value = sdt;
            cmd.Parameters.Add(sqlParameter2);

            SqlParameter sqlParameter4 = new SqlParameter("@TenKH", SqlDbType.NVarChar, 50);
            sqlParameter4.Value = ten;
            cmd.Parameters.Add(sqlParameter4);


            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                return true;
            }
            return false;
        }

        // Thêm dịa chỉ vào datable trong trường hợp nhập từ đơn mua
        public void themDiaChiVaoDB(string ten, string diachi, string sdt)
        {
            kn.myConnect();

            if (!kiemTraDiaChi(ten, diachi, sdt))
            {
                string sql = "INSERT INTO DiaChiKhachHang VALUES (@DiaChi, @TenTaiKhoan, @SDT, @TenKH)";
                SqlCommand cmd = new SqlCommand(sql, kn.con);

                SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
                sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
                cmd.Parameters.Add(sqlParameter0);

                SqlParameter sqlParameter1 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
                sqlParameter1.Value = diachi;
                cmd.Parameters.Add(sqlParameter1);

                SqlParameter sqlParameter2 = new SqlParameter("@SDT", SqlDbType.NVarChar, 50);
                sqlParameter2.Value = sdt;
                cmd.Parameters.Add(sqlParameter2);


                SqlParameter sqlParameter4 = new SqlParameter("@TenKH", SqlDbType.NVarChar, 50);
                sqlParameter4.Value = ten;
                cmd.Parameters.Add(sqlParameter4);

                cmd.ExecuteNonQuery();
            }


        }
        // Sửa địa chỉ
        public void suaDiaChi(string ten, string diachi , string sdt, string ten1, string diachi1, string sdt1)
        {
            kn.myConnect();
            string sql = "UPDATE DiaChiKhachHang SET DiaChi = @DC, SoDienThoai = @SoDT, TenKhachHang = @TenKhachHang where DiaChi = @DiaChi and TenTaiKhoan = @TenTaiKhoan and SoDienThoai = @SDT and TenKhachHang = @TenKH";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            SqlParameter sqlParameter1 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameter1.Value = diachi;
            cmd.Parameters.Add(sqlParameter1);

            SqlParameter sqlParameter2 = new SqlParameter("@SDT", SqlDbType.NVarChar, 50);
            sqlParameter2.Value = sdt;
            cmd.Parameters.Add(sqlParameter2);


            SqlParameter sqlParameter4 = new SqlParameter("@TenKH", SqlDbType.NVarChar, 50);
            sqlParameter4.Value = ten;
            cmd.Parameters.Add(sqlParameter4);

            SqlParameter sqlParameter5 = new SqlParameter("@DC", SqlDbType.NVarChar);
            sqlParameter5.Value = diachi1;
            cmd.Parameters.Add(sqlParameter5);

            SqlParameter sqlParameter6 = new SqlParameter("@SoDT", SqlDbType.NVarChar, 50);
            sqlParameter6.Value = sdt1;
            cmd.Parameters.Add(sqlParameter6);


            SqlParameter sqlParameter7 = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 50);
            sqlParameter7.Value = ten1;
            cmd.Parameters.Add(sqlParameter7);

            cmd.ExecuteNonQuery();
        }

        //Xóa địa chỉ
        public void xoaDiaChi(string ten, string diachi, string sdt)
        {
            //Confirm?
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                kn.myConnect();
                string sql = "DELETE FROM DiaChiKhachHang where DiaChi = @DiaChi and TenTaiKhoan = @TenTaiKhoan and SoDienThoai = @SDT and TenKhachHang = @TenKH";
                SqlCommand cmd = new SqlCommand(sql, kn.con);

                SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
                sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
                cmd.Parameters.Add(sqlParameter0);

                SqlParameter sqlParameter1 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
                sqlParameter1.Value = diachi;
                cmd.Parameters.Add(sqlParameter1);

                SqlParameter sqlParameter2 = new SqlParameter("@SDT", SqlDbType.NVarChar, 50);
                sqlParameter2.Value = sdt;
                cmd.Parameters.Add(sqlParameter2);


                SqlParameter sqlParameter4 = new SqlParameter("@TenKH", SqlDbType.NVarChar, 50);
                sqlParameter4.Value = ten;
                cmd.Parameters.Add(sqlParameter4);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable doDuLieuTimKiemDH(string TenSP)
        {
            kn.myConnect();
            string sql = "SELECT * FROM DonHangDaMua,SanPham WHERE SanPham.MaSP = DonHangDaMua.MaSP and TenSP LIKE @TenSP AND TenTaiKhoan = @TenTK";
            SqlCommand cmd = new SqlCommand(sql, kn.con);
            cmd.Parameters.AddWithValue("@TenSP", "%" + TenSP + "%");
            cmd.Parameters.AddWithValue("@TenTK", TaiKhoanDangNhap.tenTaiKhoan);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Hiện thông tin đơn hàng 
        public void TTDonHang(int madonhang, out string tenkhachhang, out string email, out string sodienthoai, out string giaxe, out string phivanchuyen, out DateTime ngaymua, out string diachi, out string tongthanhtoan)
        {
            SqlConnection connection = new SqlConnection(strconn);

            try
            {
                connection.Open();

                string query = "SELECT TenKhachHang, Email, SoDienThoai, TongTienHang, PhiVanChuyen, NgayDH, DiaChi, TongThanhToan FROM ThongTinDH WHERE MaDH = @MaDH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDH", madonhang);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tenkhachhang = reader.GetString(0);
                    email = reader.GetString(1);
                    sodienthoai = reader.GetString(2);
                    giaxe = reader.GetString(3);
                    phivanchuyen = reader.GetString(4);
                    ngaymua = reader.GetDateTime(5);
                    diachi = reader.GetString(6);
                    tongthanhtoan = reader.GetString(7);
                }
                else
                {
                    tenkhachhang = "";
                    email = "";
                    sodienthoai = "";
                    giaxe = "";
                    phivanchuyen = "";
                    ngaymua = DateTime.MinValue;
                    diachi = "";
                    tongthanhtoan = ""; 
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                tenkhachhang = "";
                email = "";
                sodienthoai = "";
                giaxe = "";
                phivanchuyen = "";
                ngaymua = DateTime.MinValue;
                diachi = "";
                tongthanhtoan = ""; 
            }
            finally
            {
                connection.Close();
            }
        }
        //Tìm kiếm sản phẩm theo loại
        public DataTable TimKiemSanPhamTheoLoai(string timKiem, string maLoaiSP)
        {
            DataTable dt = new DataTable();
            try
            {
                Connection_CSDL();
                string query = "SELECT * FROM SanPham WHERE MaLoai = @MaLoai AND TenSP LIKE '%' + @TimKiem + '%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TimKiem", timKiem);
                cmd.Parameters.AddWithValue("@MaLoai", maLoaiSP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
        public DataTable themDonHang()
        {
            kn.myConnect();
            string sql = "select MaDH from ThongTinDH where TenTaiKhoan = @TenTaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, kn.con);


            SqlParameter sqlParameter0 = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
            sqlParameter0.Value = TaiKhoanDangNhap.tenTaiKhoan;
            cmd.Parameters.Add(sqlParameter0);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable themDonHang(int MaDH)
        {
            kn.myConnect();
            string sql = "select * from ThongTinDH where MaDH = @MaDH";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            SqlParameter sqlParameter0 = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameter0.Value = MaDH;
            cmd.Parameters.Add(sqlParameter0);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Đổ dữ liệu vào bảng nhập hàng
        public DataTable DoDuLieuBaoCaoNhapHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connection_CSDL();
                string sql = @"Select NhapHang.MaSP, NhapHang.TenSP, NhapHang.Gia, NhapHang.SoLuong, NCC.TenNCC, NCC.DiaChi, NCC.SDT, NhapHang.NgayNhapHang from NhapHang inner join NCC on NhapHang.MaNCC = NCC.MaNCC ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public DataTable doDuLieuKhachHang()
        {
            string sql = "SELECT distinct TenKhachHang,SoDienThoai,DiaChi FROM ThongTinDH where TenTaiKhoan is not null";
            SqlCommand cmd = new SqlCommand(sql, kn.con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        
    }
}


