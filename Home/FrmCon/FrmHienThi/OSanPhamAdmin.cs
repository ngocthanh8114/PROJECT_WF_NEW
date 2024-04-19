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
    public partial class OSanPhamAdmin : UserControl
    {
        public OSanPhamAdmin()
        {
            InitializeComponent();
        }
        public void themSPAdmin(string MaSP, string tenSP, decimal gia, string nCC, int sL, Image anh)
        {
            lblMaSP.Text = MaSP;
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString() + " VNĐ";
            lblNCC.Text = nCC;
            lblSL.Text = sL.ToString() + " cái";
            picBoxSP.Image = anh;
        }
    }
}
