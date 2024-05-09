using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmHienThi.OTrong
{
    public partial class OSanPhamDaMuaAdmin : UserControl
    {
        public OSanPhamDaMuaAdmin()
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

        private void quayLaiSanPham()
        {
            FrmHome parentForm = this.ParentForm as FrmHome;

            if (parentForm != null)
            {
                parentForm.btnSanPham_Click(this, EventArgs.Empty);
            }
        }
    }
}
