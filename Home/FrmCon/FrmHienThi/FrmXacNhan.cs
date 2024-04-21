using Home.DuLieu;
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
    public partial class FrmXacNhan : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        private string MaSP;
       
        public FrmXacNhan(string masp)
        {
            InitializeComponent();
            MaSP = masp;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            xl.XoaSanPhamAdmin(MaSP);
            TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
            this.Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
