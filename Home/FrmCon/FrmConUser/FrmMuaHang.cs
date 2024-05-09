using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using Home;
using Home.DuLieu;
using Home.FrmCon.FrmConUser.UCThanhPhan.OTrong;

namespace Home.FrmCon.FrmHienThi
{
    public partial class FrmMuaHang : Form
    {
        //int madh;
        public FrmMuaHang()
        {
            InitializeComponent();
            this.MinimumSize = new Size(470, this.Height);
     
            this.Width = this.MinimumSize.Width;

        }
        XuLiDuLieu xl = new XuLiDuLieu();

        public int LayMaDH()
        {
            return int.Parse(lblMaDH.Text);
        }
       /* private void RoundFormCorners(Form form, int radius)
        {
            // Tạo một GraphicsPath để chứa hình dạng của form
            GraphicsPath path = new GraphicsPath();

            // Tạo một hình chữ nhật với kích thước của form
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Góc trên bên trái
            path.AddArc(rect.Right - 2 * radius, rect.Y, radius * 2, radius * 2, 270, 90); // Góc trên bên phải
            path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0, 90); // Góc dưới bên phải
            path.AddArc(rect.X, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90, 90); // Góc dưới bên trái
            path.CloseFigure();

            // Tạo một Region từ GraphicsPath
            Region region = new Region(path);

            // Gán Region cho form
            form.Region = region;
        }
*/
        private void FrmMuaHang_Load(object sender, EventArgs e)
        {
            
           // RoundFormCorners(this, 5);
            lblMaDH.Text = xl.DonHangHienTai();
            MaDonHangHienTai.maDH = int.Parse(xl.DonHangHienTai());
            if(!xl.checkDiaChi())
            {
                panelNoiDung.Controls.Clear();
                foreach (DataRow row in xl.doDiaChi().Rows)
                {
                    ODiaChi oDiaChi = new ODiaChi(this);
                    // Lấy giá trị từng cột trong hàng hiện tại
                    string diaChi = row["DiaChi"].ToString();
                    string tenKhachHang = row["TenKhachHang"].ToString();
                    string soDienThoai = row["SoDienThoai"].ToString();
                    oDiaChi.themDiaChi(tenKhachHang, soDienThoai, diaChi, 1);
                    panelNoiDung.Controls.Add(oDiaChi);
                    oDiaChi.BringToFront();
                }
            }   
            muaHangExpand = false;
        }


        public void loadFormMua(decimal tienHang, int SL)
        {
            lblTienHang.Text = tienHang.ToString("N0") + " VNĐ";
            lblPhiVanChuyen.Text = (SL*100000).ToString("N0") + " VNĐ";
            lblTong.Text = (tienHang + SL*100000).ToString("N0") + " VNĐ";
            dtpNgayMua.Text = DateTime.Now.ToString();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            int number;
            bool check = int.TryParse(txtSDT.Text, out number);
            if (!(string.IsNullOrWhiteSpace(txtHoTen.Text) && string.IsNullOrWhiteSpace(txtSDT.Text) && string.IsNullOrWhiteSpace(txtDiaChi.Text)))
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || xl.CheckEmail(txtEmail.Text))
                {
                    if (check == true && (txtSDT.Text.Length == 10 || txtSDT.Text.Length == 11))
                    {
                        string[] str1 = lblTienHang.Text.Split(' ');
                        string[] str2 = lblPhiVanChuyen.Text.Split(' ');
                        string[] str3 = lblTong.Text.Split(' ');
                        decimal tienHang = decimal.Parse(str1[0]);
                        decimal phiVC = decimal.Parse(str2[0]);
                        decimal tong = decimal.Parse(str3[0]);
                        DateTime NgayMua = DateTime.Now;

                        xl.MuaHang(txtHoTen.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, txtLoiNhan.Text, tienHang, phiVC, tong, NgayMua);
                        xl.DaMuaHang();
                        xl.capNhatDonMua(NgayMua);
                        FrmThongBao frmThongBao = new FrmThongBao();
                        xl.themDiaChiVaoDB(txtHoTen.Text, txtDiaChi.Text, txtSDT.Text);
                        //xl.themBaoHanh(txtHoTen.Text, txtSDT.Text, txtDiaChi.Text, lblMaDH.Text, NgayMua)
                        frmThongBao.hienThiThongBao("Mua hàng thành công");
                        frmThongBao.ShowDialog();
                        this.Close();
                        TongForm.DonHang.DonHang_Load(TongForm.DonHang, e);
                    }
                    else
                    {
                        FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                        frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại số điện thoại!");
                        frmBaoLoi.Show();
                    }
                }
                else
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại Email!");
                    frmBaoLoi.Show();
                }
            }
            else
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Bạn chưa nhập đầy đủ thông tin cần thiết");
                frmBaoLoi.Show();
            }


        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            timerMuaHang.Start();
        }

        private void cbGiaoHang1_Click(object sender, EventArgs e)
        {
            if(cbGiaoHang1.Checked == true) 
            { 
                cbGiaoHang2.Checked = false;
            }
            else
            {
                cbGiaoHang1.Checked = true;
            }    
        }

        private void cbGiaoHang2_Click(object sender, EventArgs e)
        {
            if (cbGiaoHang2.Checked == true)
            {
                cbGiaoHang1.Checked = false;
            }
            else
            {
                cbGiaoHang2.Checked = true;
            }
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            timerMuaHang.Start();
        }
        bool muaHangExpand = true;
        
        private void timerMuaHang_Tick(object sender, EventArgs e)
        {
            Point formLocation = this.Location;
            if (muaHangExpand == true)
            {
                this.Width = this.MinimumSize.Width;
                if (this.Width == this.MinimumSize.Width)
                {
                    muaHangExpand = false;
                    timerMuaHang.Stop();
                    this.Location = new Point(formLocation.X + 630 / 2 - 70, formLocation.Y);
                }
            }
            else
            {
                this.Width = this.MaximumSize.Width;
                if (this.Width == this.MaximumSize.Width)
                {
                    muaHangExpand = true;
                    timerMuaHang.Stop();
                    this.Location = new Point(formLocation.X - 630 / 2 + 70, formLocation.Y);
                }
            }
        }

        public void themDiaChi(string hoTen, string sdt, string diaChi)
        {
            txtHoTen.Text = hoTen;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diaChi;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
