using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.FrmDichVu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class ChiTietBaoHanh : UserControl
    {
        public ChiTietBaoHanh()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        public void addHienThi(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                OBaoHanh oBaoHanh = new OBaoHanh();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                int MaDH = row.Field<int>("MaDH");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                DateTime hetHan = row.Field<DateTime>("HetHan");
                TimeSpan baoHanh = hetHan - DateTime.Now;
                oBaoHanh.themBaoHanh(tenSP, MaDH, SL, baoHanh);
                panelNoiDung.Controls.Add(oBaoHanh);
                oBaoHanh.BringToFront();
            }
        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BaoHanh_Load(object sender, EventArgs e)
        {
            panelNoiDung.Controls.Clear();
            addHienThi(xl.ddoDuLieuBaoHanh(lblTenKH.Text, lblSDT.Text, lblDiaChi.Text));
        }
    }
}
