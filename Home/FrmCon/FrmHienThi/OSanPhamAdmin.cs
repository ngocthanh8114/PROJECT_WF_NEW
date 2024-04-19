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
        public OSanPhamAdmin()
        {
            InitializeComponent();
        }

        public string Get_lblMaSP()
        {
            return lblMaSP.Text;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa trong DB
                xl.Connection_CSDL();
                xl.XoaSanPhamAdmin(lblMaSP.Text);
                //Load lại SP
                TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Hiện Form
            FrmCapNhatHH frmCapNhatHH = new FrmCapNhatHH();
            frmCapNhatHH.ShowDialog();
        }
    }
}
