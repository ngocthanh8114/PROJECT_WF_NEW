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
        public void themDonHang(string tenSP, decimal gia, int SL, Image anh, byte TrangThai)
        {
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString() + " VNĐ";
            numSL.Value = SL;
            picBoxSP.Image = anh;
            lblKhuyenMai.Text = gia.ToString() + " VNĐ";
            if (TrangThai == 1)
            {
                cbDonHang.Checked = true;
            }
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
            TongForm.DonHang.cbDieuKhoan_Click(sender, e);  


        }

        private void ODonHang_Load(object sender, EventArgs e)
        {
            numSL.Minimum = 0;
            numSL.Maximum = 100;

            numSL.ValueChanged += new EventHandler(numSL_ValueChanged);
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numSL.Value;
            string TenSP = lblTenSP.Text.ToString();

            // Lấy số lượng từ numSL
            int SL = (int)numSL.Value;

            if (value > xl.KiemTraSoLuongSP(TenSP))
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Số lượng sản phẩm không đủ để mua");
                frmBaoLoi.Show();

                numSL.Value = xl.KiemTraSoLuongSP(TenSP);
            }
        }


        //-------------NgocThanh--------------------

    }
}
