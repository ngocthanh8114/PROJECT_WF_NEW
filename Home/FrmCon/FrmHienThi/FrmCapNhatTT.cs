using Home.DuLieu;
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

namespace Home.FrmCon.FrmHienThi
{
    public partial class FrmCapNhatTT : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public FrmCapNhatTT()
        {
            InitializeComponent();
        }
        private void cbtnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCapNhatTT_Load(object sender, EventArgs e)
        {
            txt_Email.Text = TaiKhoanDangNhap.email;
            txt_HoTen.Text = TaiKhoanDangNhap.tenNguoiDung;
            txt_TenTK.Text = TaiKhoanDangNhap.tenTaiKhoan;
            txt_SDT.Text = TaiKhoanDangNhap.soDienThoai;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            xl.CapNhatTaiKhoan(txt_HoTen.Text, txt_Email.Text,txt_SDT.Text, lblEm, lblSoDT, lblTenND);
            
            if (xl.capNhatTaiKhoan && lblEm.Visible == false && lblSoDT.Visible == false && lblTenND.Visible == false)
            {   
                //this.Close();
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Cập nhật thông tin tài khoản thành công!");
                frmThongBao.Show();
                TongForm.TaiKhoan.TaiKhoan_Load(TongForm.TaiKhoan, e);
            }
        }
    }
}
