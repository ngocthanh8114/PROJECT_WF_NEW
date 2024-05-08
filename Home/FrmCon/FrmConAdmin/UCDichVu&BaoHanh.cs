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

        private void btnDichVu_Click(object sender, EventArgs e)
        {
           
           DichVuAdmin dichVuAdmin = new DichVuAdmin();
            PanelNoidung.Controls.Add(dichVuAdmin);
            dichVuAdmin.BringToFront();
        }
    }
}
