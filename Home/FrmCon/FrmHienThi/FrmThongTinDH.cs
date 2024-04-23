using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class FrmThongTinDH : Form
    {
        private int MaDH;
        public FrmThongTinDH(int MDH)
        {
            InitializeComponent();
            MaDH = MDH;
        }


        XuLiDuLieu xl = new XuLiDuLieu();

        private void FrmThongTinDH_Load(object sender, EventArgs e)
        {
            

            DateTime ngaymua;
            if (DateTime.TryParse(dtngaymua.Text, out ngaymua))
            {
                string tenkhachhang, email, sodienthoai, giaxe, phivanchuyen, diachi;
                string tongthanhtoan;

                xl.TTDonHang(MaDH, out tenkhachhang, out email, out sodienthoai, out giaxe, out phivanchuyen, out ngaymua, out diachi, out tongthanhtoan);

                lblKhachHang.Text = tenkhachhang;
                lblEmail.Text = email;
                lblSDT.Text = sodienthoai;
                lblGiaXe.Text = giaxe;
                lblPhiVanChuyen.Text = phivanchuyen;
                dtngaymua.Text = ngaymua.ToString();
                lbldiachi.Text = diachi;
                lblTongTien.Text = tongthanhtoan; 
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
