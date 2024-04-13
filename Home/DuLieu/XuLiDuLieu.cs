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
        public void DatHang(string MaSP, string TenSP, decimal Gia, int SoLuong)
        {
            string sql = "INSERT INTO DonHang_1 (MaSP, TenSP, Gia, SoLuong) VALUES (@MaSP, @TenSP, @Gia, @SoLuong)";
            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("MaSP", MaSP);
            cmd.Parameters.AddWithValue("TenSP", TenSP);
            cmd.Parameters.AddWithValue("Gia", Gia);
            cmd.Parameters.AddWithValue("SoLuong", SoLuong);
            cmd.ExecuteNonQuery();

        }
        //------------------------------------------NgocThanh---------------------------------------------

    }
}
