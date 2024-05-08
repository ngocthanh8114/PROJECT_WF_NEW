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
using Home.FrmCon.FrmConUser.UCThanhPhan.OTrong;

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
                int nam = row.Field<int>("BaoHanh");
                Image anh = xl.ByteArrToImage(b);
                oSanPham.themSP(maSP, tenSP, gia, NCC, SL, anh, nam);
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
            txtTimKiem.Text = "";
            
            cbLocGia.SelectedIndex = -1;
            if (panelNoiDung != null)
            {
                panelNoiDung.Controls.Clear();
            }

            string LoaiSP = cboLoaiSP.Text;
            string MaLoai = xl.xuLiMaLoai(LoaiSP);
            addSanPham(xl.doDuLieu(MaLoai));
            UpdateGiaComboBox();
        }

       
               

        
        private void LocSanPham()
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

                switch (selectedGia)
                {
                    case "Dưới 20 triệu":
                        maxPrice = 20000000;
                        break;
                    case "Từ 20 triệu đến 50 triệu":
                        minPrice = 20000000;
                        maxPrice = 50000000;
                        break;
                    case "Từ 50 triệu đến 150 triệu":
                        minPrice = 50000000;
                        maxPrice = 150000000;
                        break;
                    case "Từ 150 triệu đến 300 triệu":
                        minPrice = 150000000;
                        maxPrice = 300000000;
                        break;
                    case "Trên 300 triệu":
                        minPrice = 300000000;
                        break;
                    case "Dưới 50 nghìn":
                        maxPrice = 50000;
                        break;
                    case "Từ 50 nghìn đến 100 nghìn":
                        minPrice = 50000;
                        maxPrice = 100000;
                        break;
                    case "Từ 100 nghìn đến 200 nghìn":
                        minPrice = 100000;
                        maxPrice = 200000;
                        break;
                    case "Từ 200 nghìn đến 300 nghìn":
                        minPrice = 200000;
                        maxPrice = 300000;
                        break;
                    case "Trên 300 nghìn":
                        minPrice = 300000;
                        break;
                    case "Dưới 100 nghìn":
                        maxPrice = 100000;
                        break;
                    case "Từ 100 nghìn đến 500 nghìn":
                        minPrice = 100000;
                        maxPrice = 500000;
                        break;
                    case "Từ 500 nghìn đến 1 triệu":
                        minPrice = 500000;
                        maxPrice = 1000000;
                        break;
                    case "Từ 1 triệu đến 5 triệu":
                        minPrice = 1000000;
                        maxPrice = 5000000;
                        break;
                    case "Trên 5 triệu":
                        minPrice = 5000000;
                        break;
                    default:
                        break;
                }

                string maLoaiSP = xl.xuLiMaLoai(selectedLoaiSP);
                DataTable filteredProducts = xl.LocSanPhamTheoLoaiVaGia(maLoaiSP, minPrice, maxPrice);
                if (filteredProducts.Rows.Count > 0)
                {
                    addSanPham(filteredProducts);
                }
                else 
                {
                    panelNoiDung.Controls.Clear();
                    SanPhamTrong donHangTrong = new SanPhamTrong();
                    donHangTrong.themNoiDung("Không có sản phẩm nào!", "Chúng tôi sẽ sớm cập nhật sản phẩm trong khoản giá này cho bạn!");
                    panelNoiDung.Controls.Add(donHangTrong);
                }
            }

        }
        private void UpdateGiaComboBox()
        {
            if (cboLoaiSP.SelectedItem == null)
            {
                return;
            }
            cbLocGia.Items.Clear();
            string selectedLoaiSP = cboLoaiSP.SelectedItem.ToString();
            switch (selectedLoaiSP)
            {
                case "Xe Phân Khối Lớn":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 20 triệu", "Từ 20 triệu đến 50 triệu", "Từ 50 triệu đến 150 triệu", "Từ 150 triệu đến 300 triệu", "Trên 300 triệu" });
                    break;
                case "Xe Số":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 20 triệu", "Từ 20 triệu đến 50 triệu", "Từ 50 triệu đến 150 triệu", "Từ 150 triệu đến 300 triệu", "Trên 300 triệu" });
                    break;
                case "Xe Côn Tay":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 20 triệu", "Từ 20 triệu đến 50 triệu", "Từ 50 triệu đến 150 triệu", "Từ 150 triệu đến 300 triệu", "Trên 300 triệu" });
                    break;
                case "Xe Tay Ga":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 20 triệu", "Từ 20 triệu đến 50 triệu", "Từ 50 triệu đến 150 triệu", "Từ 150 triệu đến 300 triệu", "Trên 300 triệu" });
                    break;
                case "Hóa Chất":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 50 nghìn", "Từ 50 nghìn đến 100 nghìn", "Từ 100 nghìn đến 200 nghìn", "Từ 200 nghìn đến 300 nghìn", "Trên 300 nghìn" });
                    break;
                case "Phụ Tùng":
                    cbLocGia.Items.AddRange(new string[] { "Dưới 100 nghìn", "Từ 100 nghìn đến 500 nghìn", "Từ 500 nghìn đến 1 triệu", "Từ 1 triệu đến 5 triệu", "Trên 5 triệu" });
                    break;
                default:
                    break;
            }
        }
        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cbLocGia.SelectedIndex = -1;
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
               cboLoaiSP_SelectedIndexChanged(sender, e);
            }
            else
            {
                string timKiem = txtTimKiem.Text;
                string selectedLoaiSP = cboLoaiSP.SelectedItem.ToString();
                string maLoaiSP = xl.xuLiMaLoai(selectedLoaiSP);
                DataTable dtSanPham = xl.TimKiemSanPhamTheoLoai(timKiem, maLoaiSP);

                if (dtSanPham.Rows.Count > 0)
                {
                    panelNoiDung.Controls.Clear();
                    addSanPham(dtSanPham);
                }
                else
                {
                    panelNoiDung.Controls.Clear();
                    SanPhamTrong donHangTrong = new SanPhamTrong();
                    donHangTrong.themNoiDung("Không có sản phẩm nào!", "Chúng tôi sẽ sớm cập nhật sản phẩm này cho bạn!");
                    panelNoiDung.Controls.Add(donHangTrong);
                }
                //
            }
        }

        private void cbLocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = ""; 
            LocSanPham();
        }

    }
}
