using Home.DuLieu;
using Home.FrmCon.FrmHienThi;
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
    public partial class OTatCaDichVu : UserControl
    {
        public OTatCaDichVu()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        private void OTatCaDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xl.DoDuLieuVaoBangDichVu();
            dgDichVu.DataSource = dt;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            if(dtpStart.Value > dtpEnd.Value) 
            {
                FrmBaoLoi frmBaoLoi = new FrmBaoLoi();
                frmBaoLoi.hienThiLoi("Vui lòng kiểm tra lại ngày tháng");
                frmBaoLoi.ShowDialog();
            }
            else if(cboPhanLoai.Text == "Tất cả")
            {
                dt = xl.LocDichVuTheoNgay(dtpStart.Value, dtpEnd.Value);
                dgDichVu.DataSource = dt;
            }    
            else if(cboPhanLoai.Text == "Chưa xử lí")
            {
                dt = xl.LocDichVuTheoNgayChuaXuLi(dtpStart.Value, dtpEnd.Value);
                dgDichVu.DataSource = dt;
            }    
            else
            {
                dt = xl.LocDichVuTheoNgayDaXuLi(dtpStart.Value, dtpEnd.Value);
                dgDichVu.DataSource = dt;
            }    
            
        }
    }
}
