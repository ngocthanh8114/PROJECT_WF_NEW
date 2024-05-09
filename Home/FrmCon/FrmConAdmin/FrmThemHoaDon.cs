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
            if (string.IsNullOrEmpty(txtTenKhachHang.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
       string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtMaSanPham.Text) || string.IsNullOrEmpty(txtSoLuong.Text) ||
       string.IsNullOrEmpty(txtThue.Text) || string.IsNullOrEmpty(txtTongTien.Text))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
                //return; 
            }
            else
            {
                xl.ThemHoaDon(txtTenKhachHang.Text, txtSDT.Text, txtDiaChi.Text, txtTenSanPham.Text, txtMaSanPham.Text, int.Parse(txtSoLuong.Text), decimal.Parse(txtThue.Text), decimal.Parse(txtTongTien.Text), dtngaymua.Value);
                loadDuLieu();
                txtSoLuong.ResetText();
                txtThue.ResetText();
                txtTongTien.ResetText();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                KetNoiCSDL kn = new KetNoiCSDL();

                kn.myConnect();
                string query = "SELECT * FROM HoaDonTaiCuaHang WHERE MaSanPham = @MaSanPham";
                SqlCommand command = new SqlCommand(query, kn.con);
                command.Parameters.AddWithValue("@MaSanPham", txtMaSanPham.Text);
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
                HoaDon hoaDon = new HoaDon();
                hoaDon.SetDatabaseLogon("sa", "123");
                hoaDon.SetDataSource(dataTable);

                // Hiển thị báo cáo
                FrmIn frmIn = new FrmIn();
                frmIn.crystalnhaphang.ReportSource = hoaDon;
                frmIn.Show();

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
