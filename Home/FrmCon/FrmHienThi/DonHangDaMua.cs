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

namespace Home.FrmCon.FrmHienThi
{
    public partial class DonHangDaMua : UserControl
    {
        public DonHangDaMua()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void addCBOMaHD()
        {
            cboDonMua.Items.Clear();
            DataTable dt = xl.themDonHang();

            foreach (DataRow dr in dt.Rows)
            {
                string loaiSP = "Mã đơn hàng: " + dr[0].ToString();

                cboDonMua.Items.Add(loaiSP);
            }
        }
        private void DonHangDaMua_Load(object sender, EventArgs e)
        {
            
            addCBOMaHD();   
        }
        private void addSP(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                OSanPhamDaMua oDonHangDaMua = new OSanPhamDaMua();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                int MaDH = row.Field<int>("MaDH");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                oDonHangDaMua.themDonMua(tenSP, MaDH, SL, anh);
                panelSP.Controls.Add(oDonHangDaMua);
                oDonHangDaMua.BringToFront();
            }
        }
        private void addHoaDon(int MaDH)
        {
            ODonHangDaMua oDonHangDaMua = new ODonHangDaMua();
            foreach (DataRow row in xl.themDonHang(MaDH).Rows)
            {
                string tenKhachHang = row[2].ToString();
                string email = row[3].ToString();
                string sdt = row[4].ToString();
                string diaChi = row[5].ToString();
                string loiNhac = row[6].ToString();
                decimal gia = row.Field<decimal>("TongTienHang");
                decimal phiVC = row.Field<decimal>("PhiVanChuyen");
                decimal tongTT = row.Field<decimal>("TongThanhToan");
                DateTime ngayDH = row.Field<DateTime>("NgayDH");
                oDonHangDaMua.themDuLieu(tenKhachHang, diaChi, email, loiNhac, sdt, gia, phiVC, tongTT, ngayDH);
            }
            panelNoiDung.Controls.Add(oDonHangDaMua);
            oDonHangDaMua.BringToFront();
        }
        private void cboDonMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = cboDonMua.SelectedItem.ToString().Split(' ');
            int MaDH = int.Parse(str[3]);
            panelNoiDung.Controls.Clear();
            addHoaDon(MaDH);
            panelSP.Controls.Clear();
            addSP(xl.doDuLieuDonMua(MaDH));
        }
    }
}
