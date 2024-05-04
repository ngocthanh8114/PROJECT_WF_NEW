using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class FrmThemLoiNhac : Form
    {
        static XuLiDuLieu xl = new XuLiDuLieu();
        public FrmThemLoiNhac()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtLoiNhac.Text))
            {
                xl.themLoiNhac(txtLoiNhac.Text);
                this.Close();
            }
            
        }
        
    }   
}
