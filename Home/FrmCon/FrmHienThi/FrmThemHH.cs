using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace Home.FrmCon.FrmHienThi
{
    public partial class FrmThemHH : Form
    {
        public FrmThemHH()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picBoxSP.ImageLocation = openFileDialog.FileName;
            }
        }

        private void cbtnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();

            xl.NhapHangAdmin(txtMaSP.Text, txtTenSP.Text, txtGia.Text, txt_MaNCC.Text, txtSoLuong.Text, picBoxSP.Image, txtMaLoai.Text, lblDonGia, lblSoluong);
            if(xl.NhapHang && lblDonGia.Visible == false && lblSoluong.Visible == false)
            {
                TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
                txtGia.Text = txtMaLoai.Text = txtMaSP.Text = txtSoLuong.Text = txtTenSP.Text = txt_MaNCC.Text = "";
                picBoxSP.Image = null;
            }    
        }
    }
}
