﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home;
using Home.FrmCon.FrmHienThi;
using Home.FrmCon;
using Home.TinhNang;

namespace Home.FrmCon
{
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        //-----------------------------------------NgocThanh------------------------------------------------
        XuLiDuLieu xl = new XuLiDuLieu();

        public void addDonHang(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.ODonHang oDonHang = new FrmCon.FrmHienThi.ODonHang();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("Anh");
                Image anh = xl.ByteArrToImage(b);
                oDonHang.themDonHang(tenSP, gia, SL, anh);
                panelNoiDung.Controls.Add(oDonHang);
                oDonHang.BringToFront();
            }
        }
        //-----------------------------------------NgocThanh------------------------------------------------

        public void DonHang_Load(object sender, EventArgs e)
        {
            addDonHang(xl.doDuLieu());
        }
    }
}
