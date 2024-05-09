using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.FrmDichVu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
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
    public partial class ChiTietBaoHanh : UserControl
    {
        public ChiTietBaoHanh()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        public void addHienThi(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                OBaoHanh oBaoHanh = new OBaoHanh();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                int MaDH = row.Field<int>("MaDH");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                DateTime hetHan = row.Field<DateTime>("HetHan");
                TimeSpan baoHanh = hetHan - DateTime.Now;
                int NgayBaoHanh = baoHanh.Days;
                oBaoHanh.themBaoHanh(tenSP, MaDH, SL, NgayBaoHanh, anh);
                panelNoiDung.Controls.Add(oBaoHanh);
                oBaoHanh.BringToFront();
            }
        }

        public void themNoiDung(string tenKH, string tenTK, string diaChi, string sdt, int sp)
        {
            lblTenKH.Text = tenKH;
            lblTenTK.Text = tenTK;
            lblDiaChi.Text = diaChi;
            lblSDT.Text = sdt;
            lblSP.Text = sp + " sản phẩm";
        }
        private void quayLaiKhachHang()
        {
            FrmAdmin parentForm = this.ParentForm as FrmAdmin;

            if (parentForm != null)
            {
                parentForm.btnDichVu_Click(this, EventArgs.Empty);
            }
        }

        public void BaoHanh_Load(object sender, EventArgs e)
        {
            panelNoiDung.Controls.Clear();
            string ten = lblTenKH.Text;
            string sdt = lblSDT.Text;
            string diaChi = lblDiaChi.Text;

            addHienThi(xl.ddoDuLieuBaoHanh(ten,diaChi,sdt));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            quayLaiKhachHang();
        }
    }
}
