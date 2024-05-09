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



    }
}
