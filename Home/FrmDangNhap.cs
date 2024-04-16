using Home;
using Home.DuLieu;
using Home.FrmCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Home
{
    public partial class FrmDangNhap : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "" || txtTaiKhoan.Text == "")
            {
                lberror.Visible = true;
            }
            else
            {
                try
                {
                    XuLiDuLieu xl = new XuLiDuLieu();
                    xl.Connection_CSDL();
                    FrmHome frmHome = new FrmHome();

                    DataTable dt = xl.layThongTinTK(txtTaiKhoan.Text, txtMatKhau.Text);
                    DataRow row = dt.Rows[0];
                    TaiKhoanDangNhap.tenTaiKhoan = row["TenTaiKhoan"].ToString();
                    TaiKhoanDangNhap.tenNguoiDung = row["TenNguoiDung"].ToString();
                    TaiKhoanDangNhap.email = row["Email"].ToString();
                    TaiKhoanDangNhap.soDienThoai = row["SoDienThoai"].ToString();
                    xl.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text, frmHome);
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("Bạn đã nhập tài khoản hoặc mật khẩu sai");
                    lberror.Visible = true;
                    txtMatKhau.ResetText();
                    txtMatKhau.Focus();
                }
            }
            
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTaiKhoan.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangNhap.Focus();
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Hide();
                this.Show();
            }
        }

        private void phide_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '•')
            {
                peye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKi frmDangKi = new FrmDangKi();
            frmDangKi.Show();
            this.Hide();
        }

        private void lbquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frm = new FrmQuenMatKhau();
            frm.Show();
            this.Hide();
        }
    }
}
