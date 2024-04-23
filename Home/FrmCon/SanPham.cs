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
using System.Data.SqlClient;
using System.IO;
using Home.DuLieu;

namespace Home.FrmCon
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }

        XuLiDuLieu xl = new XuLiDuLieu();
        private void addSanPham(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.OSanPham oSanPham = new FrmCon.FrmHienThi.OSanPham();
                // Lấy giá trị từng cột trong hàng hiện tại
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                string maNCC = row["MaNCC"].ToString();
                string NCC = xl.xuLiMaNCC(maNCC);
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                oSanPham.themSP(maSP, tenSP, gia, NCC, SL, anh);
                panelNoiDung.Controls.Add(oSanPham);
                oSanPham.BringToFront();
            }
        }



        public void SanPham_Load(object sender, EventArgs e)
        {
            
            cboLoaiSP.Items.Clear();
            DataTable dt = xl.themLoaiSP();
            
            foreach (DataRow dr in dt.Rows)
            {
                string loaiSP = dr["LoaiSP"].ToString();

                cboLoaiSP.Items.Add(loaiSP);
            }
            
            cboLoaiSP.StartIndex = 4;

        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocGia.SelectedIndex = -1;
            if (panelNoiDung != null)
            {
                panelNoiDung.Controls.Clear();
            }

            string LoaiSP = cboLoaiSP.Text;
            string MaLoai = xl.xuLiMaLoai(LoaiSP);
            addSanPham(xl.doDuLieu(MaLoai));
            
            if (LoaiSP != "Xe Phân Khối Lớn" && LoaiSP != "Xe Côn Tay" && LoaiSP != "Xe Tay Ga" && LoaiSP != "Xe Số")
            {
                cbLocGia.Visible = false;
            }
            else
            {
                cbLocGia.Visible = true;
            }
            
        }
        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
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
                if (xl.TimKiemSanPham(txtTimKiem.Text).Rows.Count > 0)
                {
                    xl.Connection_CSDL();
                    if (panelNoiDung.Controls.Count > 0)
                    {
                        panelNoiDung.Controls.Clear();
                    }
                    addSanPham(xl.TimKiemSanPham(txtTimKiem.Text));
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

        private void cbLocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelNoiDung != null)
            {
                panelNoiDung.Controls.Clear();
            }
            
            string selectedGia = cbLocGia.SelectedItem as string;
            string selectedLoaiSP = cboLoaiSP.SelectedItem as string;

            if (selectedGia != null && selectedLoaiSP != null)
            {
                decimal minPrice = 0;
                decimal maxPrice = decimal.MaxValue;

                if (selectedGia == "Dưới 20 triệu")
                {
                    maxPrice = 20000000;
                }
                else if (selectedGia == "Từ 20 triệu đến 50 triệu")
                {
                    minPrice = 20000000;
                    maxPrice = 50000000;
                }
                else if (selectedGia == "Từ 50 triệu đến 150 triệu")
                {
                    minPrice = 50000000;
                    maxPrice = 150000000;
                }
                else if (selectedGia == "Từ 150 triệu đến 300 triệu")
                {
                    minPrice = 150000000;
                    maxPrice = 300000000;
                }
                else if (selectedGia == "Trên 300 triệu")
                {
                    minPrice = 300000000;
                }

                string maLoaiSP = xl.xuLiMaLoai(selectedLoaiSP);
                DataTable filteredProducts = xl.LocSanPhamTheoLoaiVaGia(maLoaiSP, minPrice, maxPrice);
                if (filteredProducts.Rows.Count > 0)
                {
                    addSanPham(filteredProducts);
                }
                else
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Không tìm thấy sản phẩm trong khoảng giá và loại sản phẩm này.");
                    frmBaoLoi.Show();
                }
            }

        }

    }
}
