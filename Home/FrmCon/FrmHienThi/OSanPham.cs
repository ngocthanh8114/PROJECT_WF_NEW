using Home.FrmCon.FrmHienThi;
using Home.TinhNang;
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
    public partial class OSanPham : UserControl
    {
        public OSanPham()
        {
            InitializeComponent();
        }

        public void themSP(string MaSP, string tenSP,decimal gia, string nCC, int sL, Image anh)
        {
            lblMaSP.Text = MaSP;    
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString() + " VNĐ";
            lblNCC.Text = nCC;
            lblSL.Text = sL.ToString() + " cái";
            picBoxSP.Image = anh;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            XuLiDuLieu xl = new XuLiDuLieu();
            FrmThongBao frmThongBao = new FrmThongBao();
            frmThongBao.Show();

            // Them MaSP vao table DonHang_1
            xl.Connection_CSDL();
            string line = lblGia.Text.ToString();
            string[] arr = line.Split(' ');
            string Gia = arr[1];

            xl.DatHang(lblMaSP.Text, lblTenSP.Text, decimal.Parse(Gia), (int)numSL.Value);
        }
    }
}
