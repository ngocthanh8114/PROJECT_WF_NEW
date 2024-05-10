using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
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

namespace Home.FrmCon.FrmConAdmin
{
    public partial class FrmThemNhanVien : Form
    {
        public FrmThemNhanVien()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureAnhNV.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            int tuoi;
            decimal luong;
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text) || string.IsNullOrWhiteSpace(txtTenNhanVien.Text) ||
      string.IsNullOrWhiteSpace(txtCanCuoc.Text) || string.IsNullOrWhiteSpace(txtTuoi.Text) ||
      string.IsNullOrWhiteSpace(txtKinhNghiem.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
      string.IsNullOrWhiteSpace(txtLuong.Text) || pictureAnhNV.Image == null)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng nhập lại thông tin!");
                frmBaoLoi.Show();
            }
            else if (!int.TryParse(txtTuoi.Text, out tuoi) || tuoi < 18 || tuoi > 100)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Tuổi phải là một số nguyên từ 18 đến 100!");
                frmBaoLoi.Show();
                return;
            }
            else if (!decimal.TryParse(txtLuong.Text, out luong) || luong <= 0)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Lương phải là một số dương!");
                frmBaoLoi.Show();
                return;
            }
            else
            {
                byte[] anhBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureAnhNV.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Chỉ định định dạng ảnh của bạn ở đây
                    anhBytes = ms.ToArray();
                }

                xl.ThemNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtCanCuoc.Text, tuoi, txtKinhNghiem.Text, txtDiaChi.Text, luong, anhBytes);
                TongForm.UCNhanVien.UCNhanVien_Load(sender, EventArgs.Empty);
            }
        }
    }
}
