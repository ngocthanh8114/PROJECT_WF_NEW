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
using Home.TinhNang;

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

        public void addSanPham(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.ODonHang oDonHang = new FrmCon.FrmHienThi.ODonHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                string maNCC = row["MaNCC"].ToString();
                string NCC = xl.xuLiMaNCC(maNCC);
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                oDonHang.themDonHang(tenSP, gia, anh);
                panelNoiDung.Controls.Add(oDonHang);
                oDonHang.BringToFront();
            }
        }
        //-----------------------------------------NgocThanh------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {
            ODonHang oDonHang = new ODonHang();
            panelNoiDung.Controls.Add(oDonHang);
        }

        public event EventHandler loadGiaTien;

        public void DonHang_Load(object sender, EventArgs e)
        {
            DataTable dt = xl.themLoaiSP();
            foreach (DataRow dr in dt.Rows)
            {
                string loaiSP = dr["LoaiSP"].ToString();
                //cboLoaiSP.Items.Add(loaiSP);
            }
            //cboLoaiSP.StartIndex = 0;
        }
    }
}
