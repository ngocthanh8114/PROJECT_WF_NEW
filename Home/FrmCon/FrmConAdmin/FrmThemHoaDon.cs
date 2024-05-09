using Home.DuLieu;
using Home.FrmCon.FrmBaoCao;
using Home.FrmCon.FrmHienThi;
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

namespace Home.FrmCon.FrmConAdmin
{
    public partial class FrmThemHoaDon : Form
    {
        public FrmThemHoaDon()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();

        KetNoiCSDL kn = new KetNoiCSDL();
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text) ||
      string.IsNullOrWhiteSpace(txtSDT.Text) ||
      string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
      string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
      string.IsNullOrWhiteSpace(txtMaSanPham.Text) ||
      string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
      string.IsNullOrWhiteSpace(txtThue.Text) ||
      string.IsNullOrWhiteSpace(txtTongTien.Text))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
                return;
            }

            // Tiến hành thêm hóa đơn
            try
            {
                xl.ThemHoaDon(txtTenKhachHang.Text,
                              txtSDT.Text,
                              txtDiaChi.Text,
                              txtTenSanPham.Text,
                              txtMaSanPham.Text,
                              int.Parse(txtSoLuong.Text),
                              decimal.Parse(txtThue.Text),
                              decimal.Parse(txtTongTien.Text),
                              dtngaymua.Value);

                // Sau khi thêm hóa đơn thành công, làm mới dữ liệu và các trường nhập liệu
                loadDuLieu();
                txtThue.ResetText();
                txtTongTien.ResetText();
            }
            catch (FormatException)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Số lượng, thuế và tổng tiền phải là số!");
                frmBaoLoi.Show();
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối CSDL
                KetNoiCSDL kn = new KetNoiCSDL();
                kn.myConnect();

               
                string query = "SELECT TOP 1 * FROM HoaDonTaiCuaHang WHERE MaSanPham = @MaSanPham ORDER BY NgayMua DESC";
                SqlCommand command = new SqlCommand(query, kn.con);
                command.Parameters.AddWithValue("@MaSanPham", txtMaSanPham.Text);

              
                DataTable dataTable = new DataTable();

                
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                  
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.SetDatabaseLogon("sa", "123");

                  
                    hoaDon.SetDataSource(dataTable);

                    // Hiển thị báo cáo
                    FrmIn frmIn = new FrmIn();
                    frmIn.crystalnhaphang.ReportSource = hoaDon;
                    frmIn.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho mã sản phẩm này.");
                }

                // Đóng kết nối CSDL
                kn.myClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void loadDuLieu()
        {
            DataTable dt = new DataTable();
            dt = xl.DoDuLieuDichVuVaoHoaDon();
            dgHoaDon.DataSource = dt;
        }
        private void FrmThemHoaDon_Load(object sender, EventArgs e)
        {
            
            loadDuLieu();
        }
    }
}
