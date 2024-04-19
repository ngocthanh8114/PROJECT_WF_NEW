﻿using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmHienThi
{
    public partial class FrmCapNhatHH : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public FrmCapNhatHH()
        {
            InitializeComponent();
        }

        private void cbtnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCapNhatHH_Load(object sender, EventArgs e)
        {
            OSanPhamAdmin oSanPhamAdmin = new OSanPhamAdmin();
            txtMaSP.Text = oSanPhamAdmin.Get_lblMaSP();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();
            xl.SuaThongTinSanPhamAdmin(txt_MaNCC.Text, txtTenSP.Text, txtMaLoai.Text, txtSoLuong.Text, txtGia.Text, txtMaSP.Text);
            FrmThongBao frmThongBao = new FrmThongBao();
            frmThongBao.hienThiThongBao("Sửa thông tin thành công");
            frmThongBao.Show();
            TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);


            //Reset Text
            txt_MaNCC.Text = txtTenSP.Text = txtMaLoai.Text = txtSoLuong.Text = txtGia.Text = txtMaSP.Text = "";
        }

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
    }
}
