﻿using Home.FrmCon.FrmHienThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Home.TinhNang;

namespace Home.FrmCon
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }

        XuLiDuLieu xl = new XuLiDuLieu();
        public void addSanPham(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                FrmCon.FrmHienThi.OSanPham oSanPham = new FrmCon.FrmHienThi.OSanPham();
                // Lấy giá trị từng cột trong hàng hiện tại
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                decimal gia = row.Field<decimal>("Gia");
                string maNCC = row["MaNCC"].ToString();
                string NCC = xl.xuLiMaNCC(maNCC);
                int SL = row.Field<int>("SoLuong");
                byte[] b = row.Field<byte[]>("HinhAnh");
                Image anh = xl.ByteArrToImage(b);
                oSanPham.themSP(maSP, tenSP, gia, NCC, SL, anh);
                panelNoiDung.Controls.Add(oSanPham);
                oSanPham.BringToFront();
            }
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = xl.themLoaiSP();
            foreach (DataRow dr in dt.Rows) 
            {
                string loaiSP = dr["LoaiSP"].ToString();
                cboLoaiSP.Items.Add(loaiSP);
            }
            cboLoaiSP.StartIndex = 0;
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(panelNoiDung != null) 
            {
                panelNoiDung.Controls.Clear();
            }

            string LoaiSP = cboLoaiSP.Text;
            string MaLoai = xl.xuLiMaLoai(LoaiSP);
            addSanPham(xl.doDuLieu(MaLoai));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OSanPham oSanPham = new OSanPham();
            panelNoiDung.Controls.Add(oSanPham);
        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
