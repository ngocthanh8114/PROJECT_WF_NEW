﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class FrmDangKi : Form
    {
        public FrmDangKi()
        {
            InitializeComponent();
        }

     

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }
    }
}
