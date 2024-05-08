using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class UCTaiKhoanAdmin : UserControl
    {
        public UCTaiKhoanAdmin()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();
        XuLiDuLieu xl = new XuLiDuLieu();
        private void LoadDataFromDatabase()
        {
            DataTable dt = xl.LayThongTinTaiKhoan("admin");

            foreach (DataRow row in dt.Rows)
            {
                string data = row["TenTaiKhoan"].ToString(); 

                OTaiKhoan oTaiKhoan = new OTaiKhoan(data);
                PanelTaiKhoan.Controls.Add(oTaiKhoan);
            }
        }

        private void UCTaiKhoanAdmin_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(txtTenNguoiDung.Text == "" || txtTenTaiKhoan.Text == "" || txtSDT.Text == "" || txtMatKhau.Text == "" || txtEmail.Text == "")
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng nhập đầy đủ thông tin!");
                frmBaoLoi.Show();
            }
            else
            {
                xl.ThemTaiKhoanAdmin(txtTenTaiKhoan.Text, txtMatKhau.Text, txtTenNguoiDung.Text, txtEmail.Text, txtSDT.Text, "admin");
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.hienThiThongBao("Thêm thành công!");
                frmThongBao.Show();

                txtTenTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtSDT.ResetText();
                txtEmail.ResetText();
                txtTenNguoiDung.ResetText();

                PanelTaiKhoan.Controls.Clear();
                LoadDataFromDatabase();
            }

        }
    }
}
