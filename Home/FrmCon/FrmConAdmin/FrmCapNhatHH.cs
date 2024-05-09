using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
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
            xl.Connection_CSDL();
            string idsp = OSanPhamAdmin.maSP;
            txtMaSP.Text = idsp;
            xl.LoadMaNCC(cboMaNCC);
            xl.LoadMaLoai(cboMaLoai);
            cboMaLoai.StartIndex = SanPhamAdmin.indexcbo;

            xl.LoadFrmCapNhatHH(idsp, txtMaSP, txtTenSP, txtGia, txtSoLuong, picBoxSP, txtBaoHanh);
            cboMaLoai.StartIndex = SanPhamAdmin.indexcbo;
            dtNgayNhapHang.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            int SoLuongCu = xl.LaySoLuong(txtMaSP.Text);
            int SoLuongMoi = int.Parse(txtSoLuong.Text) - SoLuongCu;
            if (SoLuongMoi < 0)
            {
                SoLuongMoi = 0;
            }
            try
            {
                string maloai = cboMaLoai.SelectedValue.ToString();
                string mancc = cboMaNCC.SelectedValue.ToString();
                xl.Connection_CSDL();

                xl.SuaThongTinSanPhamAdmin(mancc, txtTenSP.Text, maloai, int.Parse(txtSoLuong.Text), SoLuongMoi, txtGia.Text, txtMaSP.Text, picBoxSP.Image, Int32.Parse(txtBaoHanh.Text), dtNgayNhapHang.Value);

                if (xl.SuaHang)
                {
                    this.Close();
                    TongForm.SanPhamAdmin.SanPhamAdmin_Load(TongForm.SanPhamAdmin, e);
                }
            }
            catch(Exception ex) 
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Không thực hiện được");
                frmBaoLoi.ShowDialog();
            }
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
        private bool ValidateInput()
        {
            int soLuong;
            decimal gia;
            int baoHanh;

            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ. Vui lòng nhập số lượng lớn hơn 0.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtGia.Text, out gia) || gia <= 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ. Vui lòng nhập giá hơn 0.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtBaoHanh.Text, out baoHanh) || baoHanh < 0)
            {
                MessageBox.Show("Thời gian bảo hành không hợp lệ. Vui lòng nhập số nguyên không âm.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }


    }
}
