using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
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
using System.Xaml;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class TaiKhoanAdmin : UserControl
    {
        public TaiKhoanAdmin()
        {
            InitializeComponent();
            dtpNgayKhach.Value = DateTime.Now;
            panelTopKhach.Controls.Clear();
            dtpNgayXe.Value = DateTime.Now;
            panelTopXe.Controls.Clear();
        }
        static XuLiDuLieu xl = new XuLiDuLieu();
        private void TaiKhoanAdmin_Load(object sender, EventArgs e)
        {
            
            btnThongTin_Click(sender, e); 
            lblHoTen.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblEmail.Text = TaiKhoanDangNhap.email;
            lblTenNguoiDung.Text = TaiKhoanDangNhap.tenNguoiDung;
            lblTenTaiKhoan.Text = TaiKhoanDangNhap.tenTaiKhoan;
            lblSoDT.Text = TaiKhoanDangNhap.soDienThoai;
            themTopKhach(dtpNgayKhach.Value);
            themTopXe(dtpNgayXe.Value);
            loadLoiNhac();

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            btnThongTin.Checked = true;
            btnLoiNhac.Checked = false;
            btnThemTK.Checked = false;
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

        private void themTopKhach(DateTime dateTime)
        {
            DateTime firstDayOfMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            int i = 1;
            foreach (DataRow row in xl.doDuLieuTopKhachHang(firstDayOfMonth).Rows)
            {
                string ten = row[1].ToString();
                decimal tt = row.Field<decimal>("TongThanhToan");
                string tien = tt.ToString("N0") + " VNĐ";
                string hienThi = ten + '/' + tien;
                OTop oTop = new OTop();
                Color color;
                switch (i)
                {
                    case 1:
                        color = Color.FromArgb(192, 0, 0);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    case 2:
                        color = Color.FromArgb(0, 192, 0);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    case 3:
                        color = Color.FromArgb(0, 192, 192);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    default:
                        color = Color.Gray;
                        oTop.themOTop(hienThi, i, color);
                        break;
                }
                panelTopKhach.Controls.Add(oTop);
                //oTop.BringToFront();
                i++;
            }
            
        }

        private void themTopXe(DateTime dateTime)
        {
            
            DateTime firstDayOfMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            int i = 1;
            foreach (DataRow row in xl.doDuLieuTopXe(firstDayOfMonth).Rows)
            {
                string ten = row[2].ToString();
                string sl = row[0].ToString() + " sản phẩm";
                string hienThi = ten + '/' + sl;
                OTop oTop = new OTop();
                Color color = Color.Gray;
                switch (i)
                {
                    case 1:
                        color = Color.FromArgb(192, 0, 0);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    case 2:
                        color = Color.FromArgb(0, 192, 0);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    case 3:
                        color = Color.FromArgb(0, 192, 192);
                        oTop.themOTop(hienThi, i, color);
                        break;
                    default:
                        color = Color.Gray;
                        oTop.themOTop(hienThi, i, color);
                        break;
                }
                panelTopXe.Controls.Add(oTop);
                //oTop.BringToFront();
                i++;
            }
            
        }

        private void dtpNgayKhach_ValueChanged(object sender, EventArgs e)
        {
            panelTopKhach.Controls.Clear();
            themTopKhach(dtpNgayKhach.Value);   
        }

        private void dtpNgayXe_ValueChanged(object sender, EventArgs e)
        {
            panelTopXe.Controls.Clear();
            themTopXe(dtpNgayXe.Value);
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            btnThongTin.Checked = false;
            btnLoiNhac.Checked = false;
            btnThemTK.Checked = true;
        }

        private void btnLoiNhac_Click(object sender, EventArgs e)
        {
            btnThongTin.Checked = false;
            btnLoiNhac.Checked = true;
            btnThemTK.Checked = false;
            FrmThemLoiNhac frmThemLoiNhac = new FrmThemLoiNhac();
            frmThemLoiNhac.ShowDialog();
            btnThongTin.Checked = true;
            btnLoiNhac.Checked = false;
            btnThemTK.Checked = false;
            bangLoiNhac = xl.doLoiNhac();
            btnPrevious_Click(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index += 1;
            if(index >= bangLoiNhac.Rows.Count)
            {
                index = 0;
            }
            loadLoiNhac();
        }
        static DataTable bangLoiNhac = xl.doLoiNhac();
        int index = 0;

        private void loadLoiNhac()
        {
            if(xl.checkLoiNhac())
            {
                txtLoiNhac.Text = "Chưa có lời nhắc";
              
            }
            else
            {
                DataRow row = bangLoiNhac.Rows[index];
                txtLoiNhac.Text = row[0].ToString();
            }
           
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index <= -1)
            {
                index = bangLoiNhac.Rows.Count-1;
            }
            loadLoiNhac();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xl.xoaLoiNhac(txtLoiNhac.Text);
            bangLoiNhac = xl.doLoiNhac();
            //loadLoiNhac();
            btnPrevious_Click(sender, e);
        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
