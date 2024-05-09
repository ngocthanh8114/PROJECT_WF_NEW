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
            string maloai = cboMaLoai.SelectedValue.ToString();
            string mancc = cboMaNCC.SelectedValue.ToString();
            xl.NhapHangAdmin(txtMaSP.Text, txtTenSP.Text, txtGia.Text, mancc, txtSoLuong.Text, picBoxSP.Image, maloai, Int32.Parse(txtBaoHanh.Text) , lblDonGia, lblSoluong,dtNgayNhapHang.Value);
            if(xl.NhapHang && lblDonGia.Visible == false && lblSoluong.Visible == false)
            {
                TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
                txtGia.Text = txtMaSP.Text = txtSoLuong.Text = txtTenSP.Text = txtBaoHanh.Text = "";
                picBoxSP.Image = null;
                
            }
            //this.Close();
        }

        private void FrmThemHH_Load(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            xl.LoadMaLoai(cboMaLoai);
            xl.LoadMaNCC(cboMaNCC);
            cboMaLoai.StartIndex = 4;
        }

    }
}
