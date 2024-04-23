using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home.DuLieu;
using Home;

namespace Home.FrmCon.FrmHienThi
{
    public partial class SanPhamDaMua : UserControl
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public SanPhamDaMua()
        {
            InitializeComponent();
        }

        private void DonHangDaMua_Load(object sender, EventArgs e)
        {
            addDonMua(xl.doDuLieuDonMua());
        }

        private void addDonMua(DataTable dt) 
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
                oDonHangDaMua.themDonMua(tenSP,MaDH,SL,anh);
                panelNoiDung.Controls.Add(oDonHangDaMua);
                oDonHangDaMua.BringToFront();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

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
                if (xl.doDuLieuTimKiemDH(txtTimKiem.Text).Rows.Count > 0)
                {
                    if (panelNoiDung.Controls.Count > 0)
                    {
                        panelNoiDung.Controls.Clear();
                    }
                    addDonMua(xl.doDuLieuTimKiemDH(txtTimKiem.Text));
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
    }
}
