using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmHienThi
{
    public partial class OSanPhamAdmin : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        string masanpham;
        public OSanPhamAdmin()
        {
            InitializeComponent();
        }
        
        public string LayMSP()
        {
            return lblMaSP.Text;
        }
        public void themSPAdmin(string MaSP, string tenSP, decimal gia, string nCC, int sL, Image anh)
        {
            lblMaSP.Text = MaSP;
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            lblNCC.Text = nCC;
            lblSL.Text = sL.ToString() + " sản phẩm";
            picBoxSP.Image = anh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            masanpham = LayMSP();
            FrmXacNhan frmXacNhan = new FrmXacNhan(masanpham);
            frmXacNhan.ShowDialog();
        }
        public static string maSP;
        public void btnSua_Click(object sender, EventArgs e)
        {   
            maSP = lblMaSP.Text.ToString();
            // Hiện Form
            FrmCapNhatHH frmCapNhatHH = new FrmCapNhatHH();
            frmCapNhatHH.ShowDialog();
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSP_Click(object sender, EventArgs e)
        {

        }

        private void lblSL_Click(object sender, EventArgs e)
        {

        }

        private void lblGia_Click(object sender, EventArgs e)
        {

        }
    }
}
