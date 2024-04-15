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
    public partial class FrmBaoLoi : Form
    {

        private int thongBaoX;
        private int thongBaoY;
        public FrmBaoLoi()
        {
            InitializeComponent();
        }
        private void viTriBanDau()
        {

            // Tính toán vị trí của control so với trung tâm của màn hình chứa
            thongBaoX = this.Location.X;
            thongBaoY = this.Location.Y + 500;

            this.Location = new Point(thongBaoX, thongBaoY);
        }

        public void hienThiLoi(string loi)
        {
            lblLoi.Text = loi;
        }

        private void FormBaoLoi_Load(object sender, EventArgs e)
        {

        }

        private void timerTat_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
