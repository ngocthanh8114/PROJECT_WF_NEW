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
using Microsoft.VisualBasic;

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
            xl.resetTongTien();
            loadGiaTien();
        }

        private void cbDieuKhoan_Click(object sender, EventArgs e)
        {
            if(cbDieuKhoan.Checked == true) btnMua.Enabled = true;
            else btnMua.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập thông tin tìm kiếm");
                frmBaoLoi.Show();
            }
            else
            {
                if(xl.doDuLieu_TimKiem(txtTimKiem.Text).Rows.Count > 0)
                {
                    xl.Connection_CSDL();
                    if (panelNoiDung.Controls.Count > 0)
                    {
                        panelNoiDung.Controls.Clear();
                    }
                    addDonHang(xl.doDuLieu_TimKiem(txtTimKiem.Text));
                }
                else
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Không tìm thấy tên sản phẩm " + txtTimKiem.Text);
                    frmBaoLoi.Show();

                }
                txtTimKiem.Text = "";
            }
        }
        decimal tongTien = 0;
        int tongSP = 0;
        // Load giá tiền
        public void loadGiaTien()
        {
            lblTongTien.Text = xl.tinhTongTien().ToString() + " VNĐ";
            lblTongSP.Text = xl.tinhSP().ToString() + " sản phẩm";
            string[] str= lblGiaThanhToan.Text.Split(' ');
            lblGiaThanhToan.Text = (xl.tinhTongTien()).ToString() + " VNĐ";
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            FrmMuaHang frmMuaHang = new FrmMuaHang();
            frmMuaHang.ShowDialog();
        }
    }
}
