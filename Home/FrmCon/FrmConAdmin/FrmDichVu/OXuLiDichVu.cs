using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class OXuLiDichVu : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        string tenkhachhang; string sodienthoai;
        public string LaySoDienThoai()
        {
            return lblSoDienThoai.Text;
        }
        public string LayTenKhachHang()
        {
            return lblTenKhachHang.Text;
        }
        public OXuLiDichVu(string tenkhachhang, string sodienthoai)
        {
            InitializeComponent();
            lblSoDienThoai.Text = sodienthoai;
            lblTenKhachHang.Text = tenkhachhang;
        }

        private void btnXuLi_Click(object sender, EventArgs e)
        {
            FrmConAdmin.FrmDichVu.FrmXuLi oXuLi = new FrmDichVu.FrmXuLi(LaySoDienThoai(),LayTenKhachHang());
            oXuLi.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OXuLiDichVu_Load(object sender, EventArgs e)
        {
            string trangThai = xl.LayTrangThaiDaXuLi(LaySoDienThoai());

            if (trangThai == "Đã xử lí")
            {
                lblTrangThai.Text = "Đã xử lí";
            }
            else
            {
                lblTrangThai.Text = "Chưa xử lí";
            }
            DateTime thoiGian = xl.LayThoiGianXuLi(LaySoDienThoai());

            // Hiển thị dữ liệu thời gian trên label
            lblThoiGian.Text = thoiGian.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
