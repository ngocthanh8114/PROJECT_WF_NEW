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
            int SoLuongCu = xl.LaySoLuong(txtMaSP.Text);
            int SoLuongMoi = int.Parse(txtSoLuong.Text) - SoLuongCu;
            if (SoLuongMoi < 0)
            {
                // Hiển thị thông báo hoặc xử lý lỗi khi số lượng mới là số âm
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
                MessageBox.Show(ex.ToString());
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

    }
}
