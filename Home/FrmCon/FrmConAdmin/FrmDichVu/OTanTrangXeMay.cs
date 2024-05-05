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

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class OTanTrangXeMay : UserControl
    {
        public OTanTrangXeMay()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();

        private void LoadDataFromDatabase()
        {
            DataTable dt = xl.LayThongTinDichVu("Tân trang xe máy");

            foreach (DataRow row in dt.Rows)
            {
                string tenkhachhang = row["TenKhachHang"].ToString();
                string sodienthoai = row["SoDienThoai"].ToString();

                OXuLiDichVu oXuLiDichVu = new OXuLiDichVu(tenkhachhang, sodienthoai);
                PannelNoiDung2.Controls.Add(oXuLiDichVu);
                oXuLiDichVu.BringToFront();
            }
        }

        private void OTanTrangXeMay_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
    }
}
