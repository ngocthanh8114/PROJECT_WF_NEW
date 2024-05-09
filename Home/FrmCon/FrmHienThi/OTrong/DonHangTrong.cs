using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConUser.UCThanhPhan.OTrong
{
    public partial class DonHangTrong : UserControl
    {
        public DonHangTrong()
        {
            InitializeComponent();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            quayLaiSanPham();
        }

        private void quayLaiSanPham()
        {
            FrmHome parentForm = this.ParentForm as FrmHome;

            if (parentForm != null)
            {
                parentForm.btnSanPham_Click(this, EventArgs.Empty);
            }
        }

        public void themNoiDung(string tieuDe, string noiDung, bool hienThi)
        {
            if (hienThi) 
            {
                btnMua.Enabled = false;
                btnMua.Visible = false;
            }
            lblTieuDe.Text = tieuDe;
            lblNoiDung.Text = noiDung;

        }

     
    }
}
