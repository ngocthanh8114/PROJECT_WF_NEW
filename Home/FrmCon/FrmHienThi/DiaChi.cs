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
                ODiaChi oDiaChi = new ODiaChi(this);
                // Lấy giá trị từng cột trong hàng hiện tại
                string diaChi = row["DiaChi"].ToString();
                string tenKhachHang = row["TenKhachHang"].ToString();
                string soDienThoai = row["SoDienThoai"].ToString();
                oDiaChi.themDiaChi(tenKhachHang, soDienThoai, diaChi, 0);
                panelNoiDung.Controls.Add(oDiaChi);
                oDiaChi.BringToFront();
            }
        }

        public void DiaChi_Load(object sender, EventArgs e)
        {
            panelNoiDung.Controls.Clear();
            addDiaChi(xl.doDiaChi());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SuaDiaChi suaDiaChi = new SuaDiaChi(this);
            suaDiaChi.ShowDialog();
            btnXoa.Checked = false;
        }
    }
}
