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

        private void OKhachHang_Load(object sender, EventArgs e)
        {
            
        }
        public void themThongTin(string ten, string sdt, string diaChi)
        {
            lblTenKH.Text = ten;
            lblDiaChi.Text = diaChi;
            lblSDT.Text = sdt;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            chiTietKhachHang();
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
    }
}
