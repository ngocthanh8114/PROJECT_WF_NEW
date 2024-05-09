using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.FrmDichVu
{
    public partial class OBaoHanh : UserControl
    {
        public OBaoHanh()
        {
            InitializeComponent();
        }
        public void themBaoHanh(string tenSP, int maDH, int SL, int ngay, Image anh )
        {
            lblMaDH.Text = maDH.ToString();
            lblTenSP.Text = tenSP;
            lblSoLuong.Text = SL.ToString() + " sản phẩm";
            lblBaoHanh.Text = ngay.ToString() + " ngày";
            picBoxSP.Image = anh;
        }
    }
}
