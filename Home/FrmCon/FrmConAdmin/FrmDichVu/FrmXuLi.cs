using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
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

namespace Home.FrmCon.FrmConAdmin.FrmDichVu
{
    public partial class FrmXuLi : Form
    {
        string sodienthoai;
        string tenkhachhang;
        public FrmXuLi(string sdt, string tenkh)
        {
           // OXuLiDichVu oXuLiDichVu = new OXuLiDichVu(tenkhachhang, sodienthoai);
            
            InitializeComponent();
            sodienthoai = sdt;
            tenkhachhang = tenkh;

        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmXuLi_Load(object sender, EventArgs e)
        {
            //OXuLiDichVu oXuLiDichVu = new OXuLiDichVu(tenkhachhang,sodienthoai);
            //sodienthoai = oXuLiDichVu.LaySoDienThoai();
            //tenkhachhang = oXuLiDichVu.LayTenKhachHang();
            DataTable dataTable = xl.DoDuLieuDichVuVaoTextBox(sodienthoai,tenkhachhang);

           
            if (dataTable.Rows.Count > 0)
            {
                txtHoTen.Text = dataTable.Rows[0]["TenKhachHang"].ToString();
                txtBienSo.Text = dataTable.Rows[0]["BienSoXe"].ToString(); 
                txtDiaChi.Text = dataTable.Rows[0]["DiaChi"].ToString(); 
                txtSDT.Text = dataTable.Rows[0]["SoDienThoai"].ToString(); 
                cboLoaiDV.Text = dataTable.Rows[0]["LoaiDichVu"].ToString(); 
                dtpNgayMua.Text = dataTable.Rows[0]["NgayThang"].ToString(); 

            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
            }
        }

        private void BtnHoanThanh_Click(object sender, EventArgs e)
        {
            xl.CapNhatTrangThai(sodienthoai, "Đã xử lí");
            FrmThongBao frmThongBao = new FrmThongBao();
            frmThongBao.hienThiThongBao("Đã xử lí");
            frmThongBao.Show();
           //this.Hide();
        }
    }
}
