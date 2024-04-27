using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmBaoCao
{
    public partial class UCBaoCaoNhapHang : UserControl
    {
        public UCBaoCaoNhapHang()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();

        SqlConnection conn = null;
        public void LoadDataToDataGridView()
        {
            DataTable dt = xl.DoDuLieuBaoCaoNhapHang();

            // Kiểm tra xem DataTable có dữ liệu không
            if (dt != null && dt.Rows.Count > 0)
            {
               dgNhapHang.DataSource = dt;
            }
            else
            {  
                MessageBox.Show("Không có dữ liệu để hiển thị!");
            }
        }

        private void UCBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            string sql = @"Select NhapHang.MaSP, NhapHang.TenSP, NhapHang.Gia, NhapHang.SoLuong, NCC.TenNCC, NCC.DiaChi, NCC.SDT, NhapHang.NgayNhapHang from NhapHang inner join NCC on NhapHang.MaNCC = NCC.MaNCC ";
            SqlCommand cmd = new SqlCommand(sql,conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            NhapHang nhapHang = new NhapHang();
            FrmIn frmIn = new FrmIn();

            nhapHang.SetDatabaseLogon("sa", "123");
            nhapHang.SetDataSource(dt);

            frmIn.crystalnhaphang.ReportSource = nhapHang;
            frmIn.crystalnhaphang.Refresh();
            frmIn.Show();
        }
    }
}
