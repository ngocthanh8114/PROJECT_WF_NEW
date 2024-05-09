using Home.DuLieu;
using Home.FrmCon.FrmConAdmin;
using Home.FrmCon.FrmHienThi;
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
    public partial class UCBaoCaoHoaDon : UserControl
    {
        public UCBaoCaoHoaDon()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void addCBOMaHD()
        {
            cboDonMua.Items.Clear();
            DataTable dt = xl.themDonHang1();

            foreach (DataRow dr in dt.Rows)
            {
                string loaiSP = "Mã đơn hàng: " + dr[0].ToString();

                cboDonMua.Items.Add(loaiSP);
            }
        }
        private void UCBaoCaoHoaDon_Load(object sender, EventArgs e)
        {

            addCBOMaHD();
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
                DateTime ngayMua = row.Field<DateTime>("NgayDH");
                oDonHangDaMua.themDonMua(tenSP, MaDH, SL, anh, ngayMua);
                panelSP.Controls.Add(oDonHangDaMua);
                oDonHangDaMua.BringToFront();
            }
        }
        private void cboDonMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = cboDonMua.SelectedItem.ToString().Split(' ');
            int MaDH = int.Parse(str[3]);
            panelNoiDung.Controls.Clear();
            addHoaDon(MaDH);
            panelSP.Controls.Clear();
            addSP(xl.doDuLieuDonMua1(MaDH));
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (cboDonMua.SelectedItem != null)
            {
                string selectedItem = cboDonMua.SelectedItem.ToString();
                int MaDH = ExtractMaDH(selectedItem);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận xóa đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        xl.xoaHoaDon(MaDH.ToString());
                        xl.xoaHoaDon1(MaDH.ToString());

                        MessageBox.Show("Đã xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        addCBOMaHD();
                        panelNoiDung.Controls.Clear();
                        panelSP.Controls.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int ExtractMaDH(string item)
        {
            
            string[] parts = item.Split(' ');
            int MaDH = int.Parse(parts[3]); 
            return MaDH;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            FrmThemHoaDon frmThemHoaDon = new FrmThemHoaDon();
            frmThemHoaDon.ShowDialog();
        }
    }
}
