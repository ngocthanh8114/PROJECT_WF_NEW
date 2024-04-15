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

namespace Home.DuLieu
{
    
    internal class XuLiDuLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        //------------------------------------------NgocThanh---------------------------------------------
        string strconn = "Data Source=.;Initial Catalog=BanXeMay;User ID=sa;Password=123";
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

        public void DangKyTK(string TenTaiKhoan, string MatKhau, string TenNguoiDung, string Email, string SoDienThoai)
        {
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
                cmd.ExecuteNonQuery();
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Đăng ký tài khoản thành công");
                frmThongBao.Show();
            }
            catch
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại thông tin");
                frmBaoLoi.Show();
            }
        }

    }
}
