using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class TaiKhoanDangNhap
    {
        public static string tenTaiKhoan;
        public static string tenNguoiDung;
        public static string email;
        public static string soDienThoai;
        //KetNoiCSDL kn = new KetNoiCSDL();
      /*  public static void LoadTaiKhoanInfoFromDatabase()
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn để lấy thông tin tài khoản

            // Ví dụ:
            SqlConnection connection = new SqlConnection(KetNoiCSDL.strconn);
            SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan", connection);
            command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tenNguoiDung = reader["TenNguoiDung"].ToString();
                    email = reader["Email"].ToString();
                    soDienThoai = reader["SoDienThoai"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tải thông tin tài khoản từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }*/
    }
}
