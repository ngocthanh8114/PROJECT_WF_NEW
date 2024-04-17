using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Home
{
    public partial class FrmDangKi : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public FrmDangKi()
        {
            InitializeComponent();
        }

        

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();

            

            xl.DangKyTK(txtTenTaiKhoan.Text, txtMatKhau.Text, txtXacNhanMatKhau.Text, txtTenNguoiDung.Text, txtEmail.Text, txtSoDienThoai.Text, lblTaiKhoan, lblMatKhau, lblEmail, lblSDT, lblTenNguoiDung);
            if (xl.dangKyThanhCong && lblTaiKhoan.Visible == false && lblMatKhau.Visible == false && lblEmail.Visible == false && lblSDT.Visible == false && lblTenNguoiDung.Visible == false)
            {
                txtTenTaiKhoan.Text = txtMatKhau.Text = txtTenNguoiDung.Text = txtEmail.Text = txtSoDienThoai.Text = txtXacNhanMatKhau.Text = "";
            }

        }

        private void FrmDangKi_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Focus();
        }
        

    }
}
