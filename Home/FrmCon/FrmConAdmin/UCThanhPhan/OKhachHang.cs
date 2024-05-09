using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;
using CrystalDecisions.Shared.Json;
using Home;
using Home.DuLieu;
using Home.FrmCon.FrmConAdmin;
using Home.FrmCon.FrmHienThi;
using Microsoft.VisualBasic;

namespace Home.FrmCon.FrmCuaAdmin
{
    
    public partial class OKhachHang : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public OKhachHang()
        {
            InitializeComponent();
        }
        //private BaoHanh baoHanh = null;
        //public OKhachHang(BaoHanh baoHanh)
        //{
        //    InitializeComponent();
        //    this.baoHanh = baoHanh;
        //}

        private void OKhachHang_Load(object sender, EventArgs e)
        {
            
        }
        public void themThongTin(string ten, string sdt, string diaChi)
        {
            lblTenKH.Text = ten;
            lblDiaChi.Text = diaChi;
            lblSDT.Text = sdt;
        }

        //public void themDonHang(string tenSP, decimal gia, int SL, Image anh, byte TrangThai)
        //{
        //    lblTenSP.Text = tenSP;
        //    lblGia.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
        //    numSL.Value = SL;
        //    picBoxSP.Image = anh;
        //    lblKhuyenMai.Text = gia.ToString("N0") + " VNĐ";
        //    if (TrangThai == 1)
        //    {
        //        cbDonHang.Checked = true;
        //    }
        //}

        public void themKhachHang(string TenKhachHang, string SoDienThoai, string DiaChi)
        {
            lblTenKH.Text = TenKhachHang;
            lblSDT.Text = SoDienThoai;
            lblDiaChi.Text = DiaChi;
            //if (TrangThai == 1)
            //{
            //    cbDonHang.Checked = true;
            //}
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if(FrmAdmin.flag == 1)
            {
                chiTietKhachHang();
            }
            else if(FrmAdmin.flag == 2)
            {
                chiTietBaoHanh();
            }
            
        }

        private void chiTietKhachHang()
        {
            FrmAdmin parentForm = this.ParentForm as FrmAdmin;

            if (parentForm != null)
            {
                parentForm.addHienThi(TongForm.ChiTietKH);
                string ten = lblTenKH.Text;
                string diaChi = lblDiaChi.Text;
                string sdt = lblSDT.Text;
                string tenTK = xl.tenTK(ten,sdt,diaChi);
                decimal tongTien = xl.tinhTongTien(ten, sdt, diaChi);
                int tongSL = xl.tinhSL(ten, sdt, diaChi);
                TongForm.ChiTietKH.themNoiDung(ten, tenTK, diaChi, sdt, tongSL, tongTien);
                TongForm.ChiTietKH.ChiTietKH_Load(this, EventArgs.Empty);
            }
        }

        private void chiTietBaoHanh()
        {
            FrmAdmin parentForm = this.ParentForm as FrmAdmin;

            if (parentForm != null)
            {
                parentForm.addHienThi(TongForm.ChiTietBaoHanh);
                string ten = lblTenKH.Text;
                string diaChi = lblDiaChi.Text;
                string sdt = lblSDT.Text;
                string tenTK = xl.tenTK(ten, sdt, diaChi);
                int tongSL = xl.tinhSL(ten, sdt, diaChi);
                TongForm.ChiTietBaoHanh.themNoiDung(ten, tenTK, diaChi, sdt, tongSL);
                TongForm.ChiTietBaoHanh.BaoHanh_Load(this, EventArgs.Empty);
            }
        }
    }
}
