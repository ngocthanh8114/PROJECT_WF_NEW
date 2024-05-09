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
            PanelNoidung.Controls.Clear();
            UCBaoCaoNhapHang uCBaoCaoNhapHang = new UCBaoCaoNhapHang();
            PanelNoidung.Controls.Add(uCBaoCaoNhapHang);
            uCBaoCaoNhapHang.Dock = DockStyle.Fill;
            uCBaoCaoNhapHang.BringToFront();
        }

        private void btnBCDoanhThu_Click(object sender, EventArgs e)
        {
            PanelNoidung.Controls.Clear();
            BaoCao baoCao = new BaoCao();
            PanelNoidung.Controls.Add(baoCao);
            baoCao.Dock = DockStyle.Fill;
            baoCao.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            PanelNoidung.Controls.Clear();
            UCBaoCaoHoaDon uCBaoCaoHoaDon = new UCBaoCaoHoaDon();
            PanelNoidung.Controls.Add(uCBaoCaoHoaDon);
            uCBaoCaoHoaDon.Dock = DockStyle.Fill;
            uCBaoCaoHoaDon.BringToFront();
        }

        private void UCBaoCao_Load(object sender, EventArgs e)
        {
            sanPhamTrong1.themNoiDung("Bạn chưa chọn tính năng!", "Vui lòng chọn tính năng bạn muốn thực hiện!");
        }
    }
}
