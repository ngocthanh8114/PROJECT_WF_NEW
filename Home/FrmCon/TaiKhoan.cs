using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home;
using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Home.FrmCon
{
    
    public partial class TaiKhoan : UserControl
    {

       
        public TaiKhoan()
        {
            InitializeComponent();
        }

        public void TaiKhoan_Load(object sender, EventArgs e)
        {
            btnThongTin_Click(sender, e);
            lblHoTen.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblSDT.Text = TaiKhoanDangNhap.soDienThoai; 
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            btnDiaChi.Checked = false;
            btnDonHang.Checked = false;
            btnThongTin.Checked = false;

            FrmHome frmHome = this.ParentForm as FrmHome;
            if (frmHome != null)
            {
                frmHome.Close();
            }
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            panelNoiDung.Controls.Clear();
            panelNoiDung.Controls.Add(thongTin);
            btnThongTin.Checked = true;
            btnDiaChi.Checked = false;
            btnDonHang.Checked = false;
            
        }


        private void quayLaiSanPham()
        {
            FrmHome parentForm = this.ParentForm as FrmHome;

            if (parentForm != null)
            {
                parentForm.btnSanPham_Click(this, EventArgs.Empty);
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            quayLaiSanPham();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            DonHangDaMua donHangDaMua = new DonHangDaMua();
            panelNoiDung.Controls.Clear();
            panelNoiDung.Controls.Add(donHangDaMua);
            btnDiaChi.Checked = false;
            btnDonHang.Checked = true;
            btnThongTin.Checked = false;
        }

        private void btnDiaChi_Click(object sender, EventArgs e)
        {
            DiaChi diaChi = new DiaChi();
            panelNoiDung.Controls.Clear();
            panelNoiDung.Controls.Add(diaChi);
            btnDiaChi.Checked = true;
            btnDonHang.Checked = false;
            btnThongTin.Checked = false;
        }

        private void btnQC_Click(object sender, EventArgs e)
        {
            quayLaiSanPham();
        }
    }
}
