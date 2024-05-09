using Home.DuLieu;
using Home.FrmCon.FrmCuaAdmin;
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
    public partial class BaoHanh : UserControl
    {
        public BaoHanh()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void BaoHanh_Load(object sender, EventArgs e)
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
    }
}
