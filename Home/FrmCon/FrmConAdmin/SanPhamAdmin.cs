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

namespace Home.FrmCon
{
    public partial class SanPhamAdmin : UserControl
    {
        public SanPhamAdmin()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void addSanPham(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.OSanPhamAdmin oSanPhamAdmin = new FrmCon.FrmHienThi.OSanPhamAdmin();
                // Lấy giá trị từng cột trong hàng hiện tại
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                string maNCC = row["MaNCC"].ToString();
                string NCC = xl.xuLiMaNCC(maNCC);
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                int nam = row.Field<int>("BaoHanh");
                oSanPhamAdmin.themSPAdmin(maSP, tenSP, gia, NCC, SL, anh, nam);
                panelNoiDung.Controls.Add(oSanPhamAdmin);
                oSanPhamAdmin.BringToFront();
            }
        }
        public void SanPhamAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = xl.themLoaiSP();
            cboLoaiSP.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string loaiSP = dr["LoaiSP"].ToString();

                cboLoaiSP.Items.Add(loaiSP);
            }
            cboLoaiSP.StartIndex = 4;
            
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelNoiDung != null)
            {
                panelNoiDung.Controls.Clear();
            }

            string LoaiSP = cboLoaiSP.Text;
            string MaLoai = xl.xuLiMaLoai(LoaiSP);
            addSanPham(xl.doDuLieu(MaLoai));
            FrmCon.FrmHienThi.OThem oThem = new OThem();
            panelNoiDung.Controls.Add(oThem);
            oThem.BringToFront();

        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
