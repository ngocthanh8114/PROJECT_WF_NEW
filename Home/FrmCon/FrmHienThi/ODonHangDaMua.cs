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

        public void themDuLieu(string ten,string diaChi,string email,string loiNhac, string sdt, decimal gia, decimal vanChuyen, decimal tong, DateTime ngay)
        {
            txtTen.Text = ten;
            txtDiaChi.Text = diaChi;
            txtEmail.Text = email;
            txtLoiNhac.Text = loiNhac;
            txtSDT.Text = sdt;
            txtGia.Text = gia.ToString();
            txtVanChuyen.Text = vanChuyen.ToString();
            txtTong.Text = tong.ToString();
            dtpNgayMua.Text = ngay.ToString();
        }

        private void guna2Shapes8_Click(object sender, EventArgs e)
        {

        }
    }
}
