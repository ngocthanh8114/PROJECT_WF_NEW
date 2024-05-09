using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class OXuLiDichVu : UserControl
    {
        public OXuLiDichVu(string tenkhachhang, string sodienthoai)
        {
            InitializeComponent();
            lblSoDienThoai.Text = sodienthoai;
            lblTenKhachHang.Text = tenkhachhang;
        }

        private void btnXuLi_Click(object sender, EventArgs e)
        {

        }
    }
}
