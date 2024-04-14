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
using static Bunifu.UI.WinForms.BunifuPictureBox;

namespace Home.TinhNang
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

        //------------------------------------------NgocThanh---------------------------------------------
        public void DatHang(string MaSP, string TenSP, decimal Gia, int SoLuong, Image Anh)
        {
            kn.myConnect();
            string sql = "INSERT INTO DonHang_1 (MaSP, TenSP, Gia, SoLuong, Anh) VALUES (@MaSP, @TenSP, @Gia, @SoLuong, @Anh)";
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

            SqlParameter sqlParameter4 = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameter4.Value = SoLuong;
            cmd.Parameters.Add(sqlParameter4);

            byte[] bytes = ImageToByteArray(Anh);
            SqlParameter sqlParameter5 = new SqlParameter("@Anh", bytes);
            cmd.Parameters.Add(sqlParameter5);

            cmd.ExecuteNonQuery();

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
            string lenh = "select * from DonHang_1";
            SqlCommand cmd = kn.con.CreateCommand();
            cmd.CommandText = lenh;

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

    }
}
