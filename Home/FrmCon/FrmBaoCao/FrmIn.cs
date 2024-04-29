using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmBaoCao
{
    public partial class FrmIn : Form
    {
        public FrmIn()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_MoTo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_MoTo.Visible = false;
            btnThuNho.Visible = true;
            
            btnThuNho.Dock = DockStyle.Right;
            
            
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnThuNho.Visible = false;
            pb_MoTo.Visible = true;
            pb_MoTo.Dock = DockStyle.Right;
            
            
           
        }
    }
}
