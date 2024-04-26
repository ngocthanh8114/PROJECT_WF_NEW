using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xaml;

namespace Home.FrmCon.FrmHienThi
{
    public partial class ODiaChi : UserControl
    {
        public int flag;
        private FrmMuaHang frmParent;
        XuLiDuLieu xl = new XuLiDuLieu();
        private DiaChi diaChi;
        public ODiaChi(FrmMuaHang frmParent)
        {
            InitializeComponent();
            this.frmParent = frmParent;
        }
        public ODiaChi()
        {
            InitializeComponent();
            
        }
        public ODiaChi(DiaChi diaChi)
        {
            InitializeComponent();
            this.diaChi = diaChi;
        }

        public void themDiaChi(string tenKH, string sdt, string diaChi, int flag )
        {
            lblTenKH.Text = tenKH;
            lblSDT.Text = sdt;
            lblDiaChi.Text = diaChi;
            this.flag = flag;
        }

        public void ODiaChi_Load(object sender, EventArgs e)
        {
            if(flag == 0) 
            {
                btnChon.Enabled = false;
                btnChon.Visible = false;
                btnSua.Enabled = true;
                btnSua.Visible = true;
            }
            else
            {
                btnChon.Enabled = true;
                btnChon.Visible = true;
                btnSua.Enabled = false;
                btnSua.Visible = false;
                btnXoa.Enabled = false;
                btnXoa.Visible = false;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSuaDiaChi suaDiaChi = new FrmSuaDiaChi(this);
            suaDiaChi.ShowDialog();
        }

        public void btnChon_Click(object sender ,EventArgs e)
        {
            frmParent.themDiaChi(lblTenKH.Text, lblSDT.Text, lblDiaChi.Text);
        }

        public List<string> GetList()
        {
            List<string> list = new List<string>();
            list.Add(lblTenKH.Text);
            list.Add(lblSDT.Text);
            list.Add(lblDiaChi.Text);
            return list;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xl.xoaDiaChi(lblTenKH.Text, lblDiaChi.Text, lblSDT.Text);
            diaChi.DiaChi_Load(diaChi, e);
        }
    }
}
