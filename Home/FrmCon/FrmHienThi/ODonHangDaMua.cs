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
    public partial class ODonHangDaMua : UserControl
    {
        public ODonHangDaMua()
        {
            InitializeComponent();
        }

        public void themDonMua(string tenSP, int MaDH, int SL, Image Anh)
        {
            lblMaDH.Text = MaDH.ToString();
            lblTenSP.Text = tenSP;
            lblSoLuong.Text = SL.ToString() + " sản phẩm";
            picBoxSP.Image = Anh;
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
