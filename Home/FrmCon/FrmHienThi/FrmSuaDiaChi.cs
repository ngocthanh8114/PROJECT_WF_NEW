using Home.DuLieu;
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
    
    public partial class FrmSuaDiaChi : Form
    {
        private int flag;

        XuLiDuLieu xl = new XuLiDuLieu();
        private ODiaChi oDiaChi;
        private DiaChi diaChi;
        public FrmSuaDiaChi(ODiaChi oDiaChi)
        {
            InitializeComponent();
            this.oDiaChi = oDiaChi;
            this.flag = 0;
        }
        public FrmSuaDiaChi(DiaChi diaChi)
        {
            InitializeComponent();
            this.diaChi = diaChi;
            this.flag = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(flag == 0 )
            {
                if(txt_HoTen.Text == "" || txtDiaChi.Text == ""  || txt_SDT.Text == "")
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Vui lòng nhập đầy đủ thông tin!");
                    frmBaoLoi.Show();
                }
                else
                {
                    List<string> list = oDiaChi.GetList();
                    xl.suaDiaChi(list[0], list[2], list[1], txt_HoTen.Text, txtDiaChi.Text, txt_SDT.Text);
                    FrmThongBao frmThongBao = new FrmThongBao();
                    frmThongBao.hienThiThongBao("Cập nhật thành công");
                    frmThongBao.ShowDialog();
                    this.Close();
                    oDiaChi.themDiaChi(txt_HoTen.Text, txt_SDT.Text, txtDiaChi.Text, 0);
                }
            }   
            else
            {
                if (txt_HoTen.Text == "" || txtDiaChi.Text == "" || txt_SDT.Text == "")
                {
                    FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                    frmBaoLoi.hienThiLoi("Vui lòng nhập đầy đủ thông tin!");
                    frmBaoLoi.Show();
                }
                else
                {
                    xl.themDiaChiVaoDB(txt_HoTen.Text, txtDiaChi.Text, txt_SDT.Text);
                    FrmThongBao frmThongBao = new FrmThongBao();
                    frmThongBao.hienThiThongBao("Cập nhật thành công");
                    frmThongBao.ShowDialog();
                    this.Close();
                    diaChi.DiaChi_Load(diaChi, e);
                }  
            }    
        }

        private void SuaDiaChi_Load(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                lblTieuDe.Text = "Cập nhật địa chỉ";
                List<string> list = oDiaChi.GetList();
                txt_HoTen.Text = list[0];
                txt_SDT.Text = list[1];
                txtDiaChi.Text = list[2];
            }
            else 
            {
                lblTieuDe.Text = "Thêm địa chỉ";
            }

            
        }
    }
}
