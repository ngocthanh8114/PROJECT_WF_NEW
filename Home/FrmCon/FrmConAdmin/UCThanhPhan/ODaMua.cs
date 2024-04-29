using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class ODaMua : UserControl
    {
        public ODaMua()
        {
            InitializeComponent();
        }

        public void themDonMua(string tenSP, int MaDH, int SL, Image Anh, DateTime NgayMua)
        {
            lblMaDH.Text = MaDH.ToString();
            lblTenSP.Text = tenSP;
            lblSoLuong.Text = SL.ToString() + " sản phẩm";
            picBoxSP.Image = Anh;
            dtpNgayMua.Text = NgayMua.ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMaDH_Click(object sender, EventArgs e)
        {

        }
    }
}
