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
    public partial class DonMuaTrong : UserControl
    {
        public DonMuaTrong()
        {
            InitializeComponent();
        }

        public void themNoiDung(string tieuDe, string noiDung)
        {
            lblTieuDe.Text = tieuDe;
            lblNoiDung.Text = noiDung;
        }
    }
}
