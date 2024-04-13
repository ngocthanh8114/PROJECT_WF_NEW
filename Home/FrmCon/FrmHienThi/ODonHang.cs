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
    public partial class ODonHang : UserControl
    {
        public ODonHang()
        {
            InitializeComponent();
        }

        private void ODonHang_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang();
            donHang.loadGiaTien += DonHang_loadGiaTien;
        }

        private void DonHang_loadGiaTien(object sender, EventArgs e)
        {
            

        }

        //-------------NgocThanh--------------------
        public void themDonHang(string tenSP, decimal gia, Image anh)
        {
            //lblMaSP.Text = MaSP;
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString() + "VNĐ";
            //lblNCC.Text = nCC;
            //lblSL.Text = sL.ToString() + " cái";
            guna2PictureBox1.Image = anh;
        }
        //-------------NgocThanh--------------------

    }
}
