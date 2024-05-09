using Home.FrmCon.FrmConAdmin.UCThanhPhan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class UCDichVu_BaoHanh : UserControl
    {
        public UCDichVu_BaoHanh()
        {
            InitializeComponent();
        }
        public void btnDichVu_Click(object sender, EventArgs e)
        {
           
            DichVuAdmin dichVuAdmin = new DichVuAdmin();
            PanelNoidung.Controls.Clear();
            PanelNoidung.Controls.Add(dichVuAdmin);
            dichVuAdmin.BringToFront();
        }

        private void UCDichVu_BaoHanh_Load(object sender, EventArgs e)
        {
            PanelNoidung.Controls.Clear();
            btnBaoHanh_Click(sender, e);
            btnDichVu.Checked = true;
            sanPhamTrong1.themNoiDung("Bạn chưa chọn tính năng!", "Vui lòng chọn tính năng bạn muốn thực hiện!");
        }


        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            BaoHanh baoHanh = new BaoHanh();
            PanelNoidung.Controls.Clear();
            PanelNoidung.Controls.Add(baoHanh);
            baoHanh.BringToFront();
        }
    }
}
