using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home;
using Home.FrmCon.FrmHienThi;
using Home.FrmCon;
using Home.DuLieu;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using Home.FrmCon.FrmConUser.UCThanhPhan.OTrong;

namespace Home.FrmCon
{
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        XuLiDuLieu xl = new XuLiDuLieu();

        public void addDonHang(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.ODonHang oDonHang = new FrmCon.FrmHienThi.ODonHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("Anh");
                Image anh = xl.ByteArrToImage(b);
                string tenTaiKhoan = TaiKhoanDangNhap.tenTaiKhoan;
                byte trangThai = row.Field<byte>("TrangThai");

                oDonHang.themDonHang(tenSP, gia, SL, anh, trangThai);
                panelNoiDung.Controls.Add(oDonHang);
                oDonHang.BringToFront();
            }
        }

        public void DonHang_Load(object sender, EventArgs e)
        {
            if (panelNoiDung.Controls.Count > 0)
            {
                panelNoiDung.Controls.Clear();
            }
            btnMua.Enabled = false;
            xl.resetTongTien();
            if(xl.checkDonHang())
            {
                DonHangTrong donHangTrong = new DonHangTrong();
                panelNoiDung.Controls.Add(donHangTrong);
                donHangTrong.BringToFront();
            }
            else 
            {
                addDonHang(xl.doDuLieu());
            } 
            loadGiaTien();
        }

        public void cbDieuKhoan_Click(object sender, EventArgs e)
        {
            if (cbDieuKhoan.Checked == true && lblTongSP.Text != "0 sản phẩm") btnMua.Enabled = true;
            else btnMua.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập thông tin tìm kiếm");
                frmBaoLoi.Show();
            }
            else
            {
                if(xl.doDuLieu_TimKiem(txtTimKiem.Text).Rows.Count > 0)
                {
                    xl.Connection_CSDL();
                    if (panelNoiDung.Controls.Count > 0)
                    {
                        panelNoiDung.Controls.Clear();
                    }
                    addDonHang(xl.doDuLieu_TimKiem(txtTimKiem.Text));
                }
                else
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Không tìm thấy tên sản phẩm " + txtTimKiem.Text);
                    frmBaoLoi.Show();

                }
                txtTimKiem.Text = "";
            }
        }

        // Load giá tiền
        public void loadGiaTien()
        {
            lblTongTien.Text = xl.tinhTongTien().ToString("N0") + " VNĐ";
            lblTongSP.Text = xl.tinhSP().ToString() + " sản phẩm";
            string[] str= lblGiaThanhToan.Text.Split(' ');
            lblGiaThanhToan.Text = (xl.tinhTongTien()).ToString("N0") + " VNĐ";
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if(xl.kiemTraDonMua())
            {
                xl.themDonMua();
            }    
            FrmMuaHang frmMuaHang = new FrmMuaHang();
            string[] str= lblTongTien.Text.Split(' ');
            decimal tongTien = decimal.Parse(str[0]);
            string[] str1 = lblTongSP.Text.Split(' ');
            int tongSP = int.Parse(str1[0]);
            frmMuaHang.loadFormMua(tongTien,tongSP);
            frmMuaHang.ShowDialog();
            btnMua.Checked = false;
        }
        private void quayLaiSanPham()
        {
            FrmHome parentForm = this.ParentForm as FrmHome;

            if (parentForm != null)
            {
                parentForm.btnSanPham_Click(this, EventArgs.Empty);
            }
        }
        private void lblTen_Click(object sender, EventArgs e)
        {
            quayLaiSanPham();
        }

        private void picBoxLoGO_Click(object sender, EventArgs e)
        {
            quayLaiSanPham();
        }

        private void btnThemAll_Click(object sender, EventArgs e)
        {
            if(xl.checkDonHang())
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.BackColor = SystemColors.Window;
                frmBaoLoi.hienThiLoi("Không có sản phẩm để thêm");
                frmBaoLoi.ShowDialog();
            }
            else
            {
                xl.turnTongTien();
                panelNoiDung.Controls.Clear();
                addDonHang(xl.doDuLieu());
                loadGiaTien();
            }
            

        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (panelNoiDung.Controls.Count == 0)
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.BackColor = SystemColors.Window;
                frmBaoLoi.hienThiLoi("Không có sản phẩm để xóa");
                frmBaoLoi.ShowDialog();
            }
            else
            {
                DonHang_Load(sender, EventArgs.Empty);
            }    
            
        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
