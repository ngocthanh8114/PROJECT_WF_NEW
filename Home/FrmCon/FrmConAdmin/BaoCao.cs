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

namespace Home.FrmCon
{
    public partial class BaoCao : UserControl
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpTuNgay.Value.Date;
            DateTime endDate = dtpToiNgay.Value.Date;
            DateTime currentDate = DateTime.Now.Date;

            if (startDate <= endDate)
            {
                if (startDate > currentDate || endDate > currentDate)
                {
                    MessageBox.Show("Ngày không hợp lệ. Ngày bắt đầu hoặc kết thúc không được lớn hơn thời gian hiện tại.");
                    return;
                }
                if (cboSanPham.SelectedItem != null && cboSanPham.Text != "Tất cả")
                {
                    string selectedProduct = cboSanPham.Text;
                    DataTable dt = xl.GetOrderDetailsByProductAndDate(selectedProduct, startDate, endDate);
                    dgv_thongke.DataSource = dt;
                    dgv_thongke.Columns["Mã Đơn Hàng"].HeaderText = "Mã Đơn Hàng";
                    dgv_thongke.Columns["Tên Sản Phẩm"].HeaderText = "Tên Sản Phẩm";
                    dgv_thongke.Columns["Số Lượng"].HeaderText = "Số Lượng";
                    dgv_thongke.Columns["Giá"].HeaderText = "Giá";
                    dgv_thongke.Columns["Thành Tiền"].HeaderText = "Thành Tiền";
                    dgv_thongke.Columns["Ngày Mua"].HeaderText = "Ngày Mua";
                    decimal totalThanhTien = xl.CalculateTotalThanhTienTungSP(selectedProduct, startDate, endDate);
                    lbl_TongTien.Text = $"Tổng tiền: {totalThanhTien.ToString("N0")} VNĐ";
                }
                else
                {
                    DataTable dt = xl.GetOrderInfoByDateRange(startDate, endDate);
                    dgv_thongke.DataSource = dt;

                    // Đặt tên cho các cột của DataGridView
                    dgv_thongke.Columns["Mã Đơn Hàng"].HeaderText = "Mã Đơn Hàng";
                    dgv_thongke.Columns["Tổng tiền"].HeaderText = "Tổng tiền";
                    dgv_thongke.Columns["Ngày mua hàng"].HeaderText = "Ngày mua hàng";

                    decimal totalTongTien = xl.CalculateTotalTongTienAllSP(startDate, endDate);
                    lbl_TongTien.Text = $"Tổng tiền: {totalTongTien.ToString("N0")} VNĐ";
                }
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ. Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
            }
        }


        private void BaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.Date; 
            dtpToiNgay.Value = DateTime.Now.Date; 
            xl.xuLiTenSP(cboSanPham);
            

        }
      
    }
}
