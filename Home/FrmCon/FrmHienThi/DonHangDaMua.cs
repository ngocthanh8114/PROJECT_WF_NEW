using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home.DuLieu;
using Home;

namespace Home.FrmCon.FrmHienThi
{
    public partial class DonHangDaMua : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public DonHangDaMua()
        {
            InitializeComponent();
        }

        private void DonHangDaMua_Load(object sender, EventArgs e)
        {
            addDonMua(xl.doDuLieuDonMua());
        }

        private void addDonMua(DataTable dt) 
        {
            foreach (DataRow row in dt.Rows)
            {
                ODonHangDaMua oDonHangDaMua = new ODonHangDaMua();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                int MaDH = row.Field<int>("MaDH");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                oDonHangDaMua.themDonMua(tenSP,MaDH,SL,anh);
                panelNoiDung.Controls.Add(oDonHangDaMua);
                oDonHangDaMua.BringToFront();
            }
        }
    }
}
