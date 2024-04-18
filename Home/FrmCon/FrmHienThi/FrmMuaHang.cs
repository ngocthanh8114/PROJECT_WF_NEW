using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using Home;
using Home.DuLieu;

namespace Home.FrmCon.FrmHienThi
{
    public partial class FrmMuaHang : Form
    {
        public FrmMuaHang()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void RoundFormCorners(Form form, int radius)
        {
            // Tạo một GraphicsPath để chứa hình dạng của form
            GraphicsPath path = new GraphicsPath();

            // Tạo một hình chữ nhật với kích thước của form
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Góc trên bên trái
            path.AddArc(rect.Right - 2 * radius, rect.Y, radius * 2, radius * 2, 270, 90); // Góc trên bên phải
            path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0, 90); // Góc dưới bên phải
            path.AddArc(rect.X, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90, 90); // Góc dưới bên trái
            path.CloseFigure();

            // Tạo một Region từ GraphicsPath
            Region region = new Region(path);

            // Gán Region cho form
            form.Region = region;
        }

        private void FrmMuaHang_Load(object sender, EventArgs e)
        {
            RoundFormCorners(this, 5);
            lblMaDH.Text = xl.DonHangHienTai();
            MaDonHangHienTai.maDH = int.Parse(xl.DonHangHienTai());
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadFormMua(decimal tienHang, int SL)
        {
            lblTienHang.Text = tienHang.ToString() + " VNĐ";
            lblPhiVanChuyen.Text = (SL*100000).ToString() + " VNĐ";
            lblTong.Text = (tienHang + SL*100000).ToString() + " VNĐ";
            
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtHoTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text) || !string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                xl.MuaHang(txtHoTen.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, txtLoiNhan.Text, lblTienHang.Text, lblPhiVanChuyen.Text, lblTong.Text);
                xl.DaMuaHang();
                xl.truSoLuongDaMua();
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Mua hàng thành công");
                frmThongBao.Show();
            }
            else
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin cần thiết");
                frmBaoLoi.Show();
            }
        }
    }
}
