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
    public partial class ODonHang : UserControl
    {
        DonHang dh = new DonHang();
        XuLiDuLieu xl = new XuLiDuLieu();
        public ODonHang()
        {
            InitializeComponent();
        }


        //-------------NgocThanh--------------------
        public void themDonHang(string tenSP, decimal gia, int SL, Image anh)
        {
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString() + " VNĐ";
            numSL.Value = SL;
            picBoxSP.Image = anh;
            lblKhuyenMai.Text = gia.ToString() + " VNĐ";
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            xl.xoaDonHang(lblTenSP.Text);
            TongForm.DonHang.DonHang_Load(TongForm.DonHang, e);
        }

        private void cbDonHang_Click(object sender, EventArgs e)
        {
            if(cbDonHang.Checked == true) 
            { 
                xl.DangDatHang(lblTenSP.Text);
            }
            else
            {
                xl.BoDatHang(lblTenSP.Text);
            }
            TongForm.DonHang.loadGiaTien();
        }


        //-------------NgocThanh--------------------

    }
}
