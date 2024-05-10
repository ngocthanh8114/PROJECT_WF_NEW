using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class FrmSuaNhanVien : Form
    {
        ONhanVien oNhanVien = null;
        // string manhanvien;
        public FrmSuaNhanVien(ONhanVien oNhanVien)
        {
            InitializeComponent();
            this.oNhanVien = oNhanVien;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        XuLiDuLieu xl = new XuLiDuLieu();


        private void LayVaHienThiThongTinNhanVien()
        {
            string maNhanVien = oNhanVien.GetMaNhanVien();
            DataTable dataTable = xl.DoDuLieuVaoNhanVien(maNhanVien);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                txtMaNhanVien.Text = maNhanVien;
                txtTenNhanVien.Text = row["TenNhanVien"].ToString();
                txtCanCuoc.Text = row["CanCuocCongDan"].ToString();
                txtTuoi.Text = row["Tuoi"].ToString();
                txtKinhNghiem.Text = row["KinhNghiem"].ToString();
                txtDiaChi.Text = row["DiaChiCuTru"].ToString();
                txtLuong.Text = row["Luong"].ToString();

                // Kiểm tra xem dữ liệu hình ảnh có null hay không trước khi gán
                if (row["Anh"] != DBNull.Value)
                {
                    byte[] imgData = (byte[])row["Anh"];
                    pictureAnhNV.Image = Image.FromStream(new System.IO.MemoryStream(imgData));
                }
                else
                {
                    // Nếu không có hình ảnh, có thể hiển thị một hình ảnh mặc định hoặc ẩn điều khiển hình ảnh
                    pictureAnhNV.Image = null; // Hoặc gán hình ảnh mặc định
                }
            }

        }

        private void FrmSuaNhanVien_Load(object sender, EventArgs e)
        {
            LayVaHienThiThongTinNhanVien();
            txtMaNhanVien.Enabled = false;
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
            }else
            {
                byte[] anhBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureAnhNV.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Chỉ định định dạng ảnh của bạn ở đây
                    anhBytes = ms.ToArray();
                }

                xl.CapNhatThongTinNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtCanCuoc.Text, tuoi, txtKinhNghiem.Text, txtDiaChi.Text, luong, anhBytes);
                TongForm.UCNhanVien.UCNhanVien_Load(sender, EventArgs.Empty);
            }

        }
    }
}
