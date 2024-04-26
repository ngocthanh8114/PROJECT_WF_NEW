using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmBaoCao
{
    public partial class UCBaoCao : UserControl
    {
        public UCBaoCao()
        {
            InitializeComponent();
        }

        private void btnBCNhaphang_Click(object sender, EventArgs e)
        {
            UCBaoCaoNhapHang uCBaoCaoNhapHang = new UCBaoCaoNhapHang();
            PanelNoidung.Controls.Add(uCBaoCaoNhapHang);
            uCBaoCaoNhapHang.BringToFront();
        }

        private void btnBCDoanhThu_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            PanelNoidung.Controls.Add(baoCao);
            baoCao.BringToFront();
        }
    }
}
