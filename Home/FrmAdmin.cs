using Home.FrmCon;
using Home.FrmCon.FrmBaoCao;
using Home.FrmCon.FrmConAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace Home
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
            
        }
        public void addHienThi(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelHienThi.Controls.Clear();
            panelHienThi.Controls.Add(uc);
            uc.BringToFront();

        }
 
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            addHienThi(TongForm.SanPhamAdmin);
            TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
            btnSanPham.Checked = true;
            btnKhachHang.Checked = false;
            btnDichVu.Checked = false;
            btnBaoCao.Checked = false;
            btnNhanVien.Checked = false;
            btnTaiKhoan.Checked = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            addHienThi(TongForm.UCBaoCao);
            btnSanPham.Checked = false;
            btnKhachHang.Checked = false;
            btnDichVu.Checked = false;
            btnBaoCao.Checked = true;
            btnNhanVien.Checked = false;
            btnTaiKhoan.Checked = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            addHienThi(TongForm.KhachHang);
            btnSanPham.Checked = false;
            btnKhachHang.Checked = true;
            btnDichVu.Checked = false;
            btnBaoCao.Checked = false ;
            btnNhanVien.Checked = false;
            btnTaiKhoan.Checked = false;
        }

       
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            UCDichVu_BaoHanh uCDichVu_BaoHanh   = new UCDichVu_BaoHanh();
            panelHienThi.Controls.Add(uCDichVu_BaoHanh);
            uCDichVu_BaoHanh.BringToFront();
            btnSanPham.Checked = false;
            btnKhachHang.Checked = false;
            btnDichVu.Checked = true;
            btnBaoCao.Checked = false;
            btnNhanVien.Checked = false;
            btnTaiKhoan.Checked = false;
        }

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            addHienThi(TongForm.TaiKhoanAdmin);
            btnSanPham.Checked = false;
            btnKhachHang.Checked = false;
            btnDichVu.Checked = false;
            btnBaoCao.Checked = false;
            btnNhanVien.Checked = false;
            btnTaiKhoan.Checked = true;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            addHienThi(TongForm.SanPhamAdmin);
            TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
            btnSanPham.Checked = true;
        }
    }
}
