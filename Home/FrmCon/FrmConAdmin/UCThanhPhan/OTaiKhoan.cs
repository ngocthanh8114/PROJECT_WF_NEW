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
    public partial class OTaiKhoan : UserControl
    {
        public OTaiKhoan(string tentaikhoan)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = tentaikhoan;
        }
    }
}
