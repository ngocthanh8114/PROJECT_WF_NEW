using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
using Home.DuLieu;
using Home.FrmCon.FrmCuaAdmin;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class ChiTietKH : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public ChiTietKH()
        {
            InitializeComponent();
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
           /*// this.Hide();
            KhachHang khachHang = new KhachHang();
            panelNoiDung.Controls.Add(khachHang);
            63333333333333333333
            khachHang.BringToFront();*/
        }


        public void themNoiDung(string tenKH, string tenTK, string diaChi, string sdt, int sp, decimal tong)
        {
            lblTenKH.Text = tenKH;
            lblTenTK.Text = tenTK;
            lblDiaChi.Text = diaChi;
            lblSDT.Text = sdt;
            lblSP.Text = sp + " sản phẩm";
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";

        }
        private void addDonMua(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ODaMua oDaMua = new ODaMua();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                int MaDH = row.Field<int>("MaDH");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                DateTime ngayMua = row.Field<DateTime>("NgayDH");
                oDaMua.themDonMua(tenSP, MaDH, SL, anh, ngayMua);
                panelNoiDung.Controls.Add(oDaMua);
                oDaMua.BringToFront();
            }
        }

        public void ChiTietKH_Load(object sender, EventArgs e)
        {
            panelNoiDung.Controls.Clear();
            addDonMua(xl.doDuLieuDonMuaAdmin(lblTenKH.Text,lblSDT.Text,lblDiaChi.Text));
        }
    }
}
