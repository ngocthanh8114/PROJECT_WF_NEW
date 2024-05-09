using Home.DuLieu;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class ONhanVien : UserControl
    {
        
        public ONhanVien()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        public string GetMaNhanVien()
        {
            return lblMaNV.Text;
        }
        public void themThongTin(string manhanvien, string tennhanvien, string tuoi, string kinhnghiem,Image anh, string luong)
        {
            lblMaNV.Text = manhanvien;
            lblKinhNghiem.Text = kinhnghiem;
            lblLuong.Text = luong;
            lblTenNhanVien.Text = tennhanvien;
            lblTuoi.Text = tuoi;
            guna2PictureBox1.Image = anh;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSuaNhanVien frmSuaNhanVien = new FrmSuaNhanVien(this);
            
            frmSuaNhanVien.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                xl.XoaNhanVien(GetMaNhanVien());
                TongForm.UCNhanVien.UCNhanVien_Load(sender, e);
            }
        }
    }
}
