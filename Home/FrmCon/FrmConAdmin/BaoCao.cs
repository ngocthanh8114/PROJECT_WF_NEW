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
            DateTime startDate;
            DateTime endDate;

            if (DateTime.TryParseExact(mtbTuNgay.Text, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out startDate) &&
                DateTime.TryParseExact(mtbToiNgay.Text, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out endDate))
            {
                if (cboSanPham.SelectedItem != null && cboSanPham.Text != "Tất cả")
                {
                    string selectedProduct = cboSanPham.Text;
                    dgv_thongke.DataSource = xl.GetOrderDetailsByProductAndDate(selectedProduct, startDate, endDate);
                    decimal totalTongTien = xl.CalculateTotalThanhTienTungSP(selectedProduct, startDate, endDate);
                    lbl_TongTien.Text = $"Tổng tiền: {totalTongTien.ToString("N0")} VNĐ";
                }
                else
                {
                    dgv_thongke.DataSource = xl.GetOrderInfoByDateRange(startDate, endDate);
                    //decimal totalTongTien = xl.CalculateTotalTongTienAllSP(startDate,endDate);
                    //lbl_TongTien.Text = $"Tổng tiền: {totalTongTien.ToString("N0")} VNĐ";
                }
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng kiểm tra lại định dạng ngày.");
            }
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            mtbTuNgay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            mtbToiNgay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            xl.xuLiTenSP(cboSanPham);
        }
    }
}
