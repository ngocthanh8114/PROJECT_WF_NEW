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
    public partial class OTop : UserControl
    {
        public OTop()
        {
            InitializeComponent();
        }

        public void themOTop(string top, int thuHang, Color color)
        {
            TopKhach.Text = top;
            lblTop.Text = thuHang.ToString();
            panelColor.BackColor = color;
            lblTop.BackColor = color;
        }

    }
}
