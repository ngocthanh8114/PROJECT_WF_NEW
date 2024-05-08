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

namespace Home.FrmCon.FrmConAdmin.UCThanhPhan
{
    public partial class OTatCaDichVu : UserControl
    {
        public OTatCaDichVu()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void OTatCaDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xl.DoDuLieuVaoBangDichVu();
            dgDichVu.DataSource = dt;

        }
    }
}
