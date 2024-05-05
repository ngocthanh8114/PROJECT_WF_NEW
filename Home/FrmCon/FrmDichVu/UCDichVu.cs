using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class UCDichVu : UserControl
    {
        public UCDichVu()
        {
            InitializeComponent();
        }

        private void UCDichVu_Load(object sender, EventArgs e)
        {
            OTatCaDichVu oTatCaDichVu = new OTatCaDichVu();
            PanelNoiDung.Controls.Add(oTatCaDichVu);
            oTatCaDichVu.BringToFront();
        }

        private void btnTanTrang_Click(object sender, EventArgs e)
        {
            OTanTrangXeMay oTanTrangXeMay = new OTanTrangXeMay();
            PanelNoiDung.Controls.Add(oTanTrangXeMay);
            oTanTrangXeMay.BringToFront();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            OTatCaDichVu oTatCaDichVu = new OTatCaDichVu();
            PanelNoiDung.Controls.Add(oTatCaDichVu);
            oTatCaDichVu.BringToFront();
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            OPhucHoiXeMay oPhucHoiXeMay = new OPhucHoiXeMay();
            PanelNoiDung.Controls.Add (oPhucHoiXeMay);
            oPhucHoiXeMay.BringToFront();
        }

        private void btnBaoDuong_Click(object sender, EventArgs e)
        {
            OBaoDuongXeMay oBaoDuongXeMay = new OBaoDuongXeMay();
            PanelNoiDung.Controls.Add(oBaoDuongXeMay);
            oBaoDuongXeMay.BringToFront();
        }

        private void btnDanNiLon_Click(object sender, EventArgs e)
        {
            ODanNilon oDanNilon = new ODanNilon();
            PanelNoiDung.Controls.Add(oDanNilon);
            oDanNilon.BringToFront();
        }

        private void btnCuuHo_Click(object sender, EventArgs e)
        {
            OCuuHo oCuuHo = new OCuuHo();
            PanelNoiDung.Controls.Add(oCuuHo);
            oCuuHo.BringToFront();
        }
    }
}
