using Home.FrmCon;
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
using Home.FrmCon.FrmHienThi;
namespace Home
{
    public partial class FrmHome : Form
    {
        
        public bool flagDangNhap = false;
        public FrmHome()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Tắt border của form
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                // Khôi phục border khi form không phải là maximum
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void addHienThi(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelHienThi.Controls.Clear();
            panelHienThi.Controls.Add(uc);
            uc.BringToFront();

        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            if(!flagDangNhap)
            {
                
            }    
            /*GioiThieu gt = new GioiThieu();
            addHienThi(gt);
            btnGioiThieu.Checked = true;
            btnSanPham.Checked = false;
            btnDichVu.Checked = false;
            btnDonHang.Checked = false;
            btnTaiKhoan.Checked = false;
            //btnGioiThieu.Enabled = false;*/
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            addHienThi(TongForm.SanPham);
            TongForm.SanPham.SanPham_Load(TongForm.SanPham, e);
            btnSanPham.Checked = true;
            btnGioiThieu.Checked = false;
            btnDichVu.Checked = false;
            btnDonHang.Checked = false;
            btnTaiKhoan.Checked = false;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            
            addHienThi(TongForm.DonHang);
            TongForm.DonHang.DonHang_Load(TongForm.DonHang, e);
            btnSanPham.Checked = false;
            btnGioiThieu.Checked = false;
            btnDichVu.Checked = false;
            btnDonHang.Checked = true;
            btnTaiKhoan.Checked = false;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            
            addHienThi(TongForm.TaiKhoan);
            TongForm.TaiKhoan.TaiKhoan_Load(TongForm.TaiKhoan, e);
            btnSanPham.Checked = false;
            btnGioiThieu.Checked = false;
            btnDichVu.Checked = false;
            btnDonHang.Checked = false;
            btnTaiKhoan.Checked = true;
        }

        /*thử commit*/
    }
}
