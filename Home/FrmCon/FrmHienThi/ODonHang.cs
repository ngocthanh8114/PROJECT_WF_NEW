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
        //-------------NgocThanh--------------------

    }
}
