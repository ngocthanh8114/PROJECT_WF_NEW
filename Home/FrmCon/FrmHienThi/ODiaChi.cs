﻿using System;
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
    public partial class ODiaChi : UserControl
    {
        public ODiaChi()
        {
            InitializeComponent();
        }

        public void themDiaChi(string tenKH, string sdt, string diaChi )
        {
            lblTenKH.Text = "  " + tenKH;
            lblSDT.Text = sdt;
            lblDiaChi.Text = diaChi;
        }
    }
}