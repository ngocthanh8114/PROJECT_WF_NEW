using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmCuaAdmin
{
    public partial class OKhachHang : UserControl
    {
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
    }
}
