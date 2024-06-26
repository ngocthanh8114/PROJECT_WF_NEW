﻿using Home.FrmCon.FrmHienThi;
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

namespace Home.FrmCon.FrmHienThi
{
    public partial class OSanPham : UserControl
    {
        public OSanPham()
        {
            InitializeComponent();
        }

        public void themSP(string MaSP, string tenSP,decimal gia, string nCC, int sL, Image anh, int nam)
        {
            lblMaSP.Text = MaSP;    
            lblTenSP.Text = tenSP;
            lblGia.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            lblNCC.Text = nCC;
            lblSL.Text = sL.ToString() + " sản phẩm";
            picBoxSP.Image = anh;
            if(nam == 0 )
            {
                lblNam.Text = "Không có";
            }    
            else
            {
                lblNam.Text = nam.ToString() + " năm";
            }    
            
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            XuLiDuLieu xl = new XuLiDuLieu();
            // Them MaSP vao table DonHang_1

            //Lấy Giá
            string line = lblGia.Text.ToString();
            string[] arr = line.Split(' ');
            decimal Gia = decimal.Parse(arr[1]);
            
            string TenSP = lblTenSP.Text.ToString();
            string MaSP = lblMaSP.Text.ToString();
            int SL = (int)numSL.Value;
            Image anh = picBoxSP.Image;

            // Xử lí nếu số lượng = 0 thì không cho đặt và thông báo lên
            if (SL > 0)
            {
                xl.DatHang(MaSP, TenSP, Gia, SL, anh);
                numSL.Value = 1;
            }
            else
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại số lượng sản phẩm!");
                frmBaoLoi.Show();
            }
            
        }
        // xử lí lỗi
    }
}
