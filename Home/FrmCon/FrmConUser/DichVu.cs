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
using Home;
using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
namespace Home.FrmCon
{
    public partial class DichVu : UserControl
    {
        public DichVu()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void DichVu_Load(object sender, EventArgs e)
        {
            dtpNgayMua.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtBienSo.Text) || string.IsNullOrWhiteSpace(cboLoaiDV.Text))
            { 
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin");
                frmBaoLoi.ShowDialog();
            }
            else 
            {
                xl.ThemDichVu(txtHoTen.Text, txtSDT.Text, txtBienSo.Text, txtDiaChi.Text, cboLoaiDV.Text, dtpNgayMua.Value );
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Đặt lịch thành công");
                frmThongBao.ShowDialog();
                txtBienSo.ResetText();
                txtDiaChi.ResetText();
                txtHoTen.ResetText();
                txtSDT.ResetText();
                cboLoaiDV.SelectedIndex = -1;
            }
        }
    }
}
