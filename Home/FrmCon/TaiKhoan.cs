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
            lblEmail.Text = TaiKhoanDangNhap.email;
            lblTenNguoiDung.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblTenTaiKhoan.Text = TaiKhoanDangNhap.tenTaiKhoan;
            lblSoDT.Text = TaiKhoanDangNhap.soDienThoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmCapNhatTT frmCapNhatTT = new FrmCapNhatTT();
            frmCapNhatTT.ShowDialog();
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
    }
}
