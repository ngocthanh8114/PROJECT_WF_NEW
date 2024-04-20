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
using System.Xaml;

namespace Home.FrmCon.FrmHienThi
{
    public partial class DiaChi : UserControl
    {
        public DiaChi()
        {
            InitializeComponent();
        }

        XuLiDuLieu xl = new XuLiDuLieu();
        private void addDiaChi(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                ODiaChi oDiaChi = new ODiaChi();
                // Lấy giá trị từng cột trong hàng hiện tại
                string diaChi = row["DiaChi"].ToString();
                string tenKhachHang = row["TenKhachHang"].ToString();
                string soDienThoai = row["SoDienThoai"].ToString();
                oDiaChi.themDiaChi(tenKhachHang, soDienThoai, diaChi);
                panelNoiDung.Controls.Add(oDiaChi);
                oDiaChi.BringToFront();
            }
        }

        private void DiaChi_Load(object sender, EventArgs e)
        {
            addDiaChi(xl.doDiaChi());
        }
    }
}
