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

namespace Home
{
    public partial class FrmQuenMatKhau : Form
    {
        XuLiDuLieu xl = new XuLiDuLieu();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            xl.Connection_CSDL();



            xl.LayLaiMatKhau(txtEmail2.Text, lbemail, lbMatKhau);
            
        }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
        }
    }
}
