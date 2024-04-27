using Home.FrmCon;
using Home.FrmCon.FrmBaoCao;
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
        private void addHienThi(UserControl uc)
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
            btnHoaDon.Checked = false;
            btnBaoCao.Checked = false;
            btnTaiKhoan.Checked = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            UCBaoCao uCBaoCao = new UCBaoCao();
            panelHienThi.Controls.Add(uCBaoCao);
            uCBaoCao.BringToFront();
            btnSanPham.Checked = false;
            btnKhachHang.Checked = false;
            btnHoaDon.Checked = false;
            btnBaoCao.Checked = true;
            btnTaiKhoan.Checked = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            addHienThi(TongForm.KhachHang);
            btnSanPham.Checked = false;
            btnKhachHang.Checked = true;
            btnHoaDon.Checked = false;
            btnBaoCao.Checked = false ;
            btnTaiKhoan.Checked = false;
        }
    }
}
