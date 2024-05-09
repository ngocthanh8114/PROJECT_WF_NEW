using Home.DuLieu;
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

namespace Home.FrmCon.FrmCuaAdmin
{
    public partial class KhachHang : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public KhachHang()
        {
            InitializeComponent();
        }

        public void addKhachHang(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmCuaAdmin.OKhachHang oKhachHang = new FrmCon.FrmCuaAdmin.OKhachHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string TenKhachHang = row["TenKhachHang"].ToString();
                string SoDienThoai = row["SoDienThoai"].ToString();
                string DiaChi = row["DiaChi"].ToString();
                oKhachHang.themKhachHang(TenKhachHang, SoDienThoai, DiaChi);
                panelNoiDung.Controls.Add(oKhachHang);
                oKhachHang.BringToFront();
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in xl.doDuLieuKhachHang().Rows)
            {
                OKhachHang oKhachHang = new OKhachHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string diaChi = row["DiaChi"].ToString();
                string tenKhachHang = row["TenKhachHang"].ToString();
                string soDienThoai = row["SoDienThoai"].ToString();
                oKhachHang.themThongTin(tenKhachHang, soDienThoai, diaChi);
                panelNoiDung.Controls.Add(oKhachHang);
                oKhachHang.BringToFront();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập thông tin tìm kiếm");
                frmBaoLoi.Show();
            }
            else
            {
                if (xl.doDuLieu_TimKiem_KH(txtTimKiem.Text).Rows.Count > 0)
                {
                    xl.Connection_CSDL();
                    if (panelNoiDung.Controls.Count > 0)
                    {
                        panelNoiDung.Controls.Clear();
                    }
                    addKhachHang(xl.doDuLieu_TimKiem_KH(txtTimKiem.Text));
                    TongForm.ChiTietKH.ChiTietKH_Load(TongForm.ChiTietKH, e);
                }
                else
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Không tìm thấy tên khách hàng" + txtTimKiem.Text);
                    frmBaoLoi.Show();
                }
                txtTimKiem.Text = "";
            }
        }
    }
}
