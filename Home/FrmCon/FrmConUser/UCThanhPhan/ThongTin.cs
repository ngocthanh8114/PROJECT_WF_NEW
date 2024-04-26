using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmHienThi
{
    public partial class ThongTin : UserControl
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            lblEmail.Text = TaiKhoanDangNhap.email;
            lblTenNguoiDung.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblTenTaiKhoan.Text = TaiKhoanDangNhap.tenTaiKhoan;
            lblSoDT.Text = TaiKhoanDangNhap.soDienThoai;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = this.ParentForm as FrmHome;
            if (frmHome != null)
            {
                frmHome.Close();
            }
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmCapNhatTT frmCapNhatTT = new FrmCapNhatTT();
            frmCapNhatTT.ShowDialog();
        }
    }
}
