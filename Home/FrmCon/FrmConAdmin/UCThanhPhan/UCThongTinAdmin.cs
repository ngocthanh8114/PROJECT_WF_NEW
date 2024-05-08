using Home.FrmCon.FrmHienThi;
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
    public partial class UCThongTinAdmin : UserControl
    {
        public UCThongTinAdmin()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmCapNhatTT frmCapNhatTT = new FrmCapNhatTT();
            frmCapNhatTT.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            /* FrmHome frmHome = this.ParentForm as FrmHome;
             if (frmHome != null)
             {
                 frmHome.Close();
             }*/

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không ?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
             
                this.ParentForm.Close();


                FrmDangNhap dn = new FrmDangNhap();
                dn.ShowDialog();
            }
        }

        private void UCThongTinAdmin_Load(object sender, EventArgs e)
        {
           // btnThongTin_Click(sender, e);
           // lblHoTen.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblEmail.Text = TaiKhoanDangNhap.email;
            lblTenNguoiDung.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblTenTaiKhoan.Text = TaiKhoanDangNhap.tenTaiKhoan;
            lblSoDT.Text = TaiKhoanDangNhap.soDienThoai;
            
        }
    }
}
