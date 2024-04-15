using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home;
using Home.FrmCon.FrmHienThi;
using Home.FrmCon;
using Home.DuLieu;

namespace Home.FrmCon
{
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        //-----------------------------------------NgocThanh------------------------------------------------
        XuLiDuLieu xl = new XuLiDuLieu();

        public void addDonHang(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.ODonHang oDonHang = new FrmCon.FrmHienThi.ODonHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("Anh");
                Image anh = xl.ByteArrToImage(b);
                string tenTaiKhoan = TaiKhoanDangNhap.tenTaiKhoan;
                oDonHang.themDonHang(tenSP, gia, SL, anh);
                panelNoiDung.Controls.Add(oDonHang);
                oDonHang.BringToFront();
            }
        }
        //-----------------------------------------NgocThanh------------------------------------------------

        public void DonHang_Load(object sender, EventArgs e)
        {
            if (panelNoiDung.Controls.Count > 0)
            {
                panelNoiDung.Controls.Clear();
            }
            addDonHang(xl.doDuLieu());
            btnMua.Enabled = false;
        }

        private void cbDieuKhoan_Click(object sender, EventArgs e)
        {
            if (cbDieuKhoan.Checked == true) btnMua.Enabled = true;
            else btnMua.Enabled = false;
        }
    }
}
