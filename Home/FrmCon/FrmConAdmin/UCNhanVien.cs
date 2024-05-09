using Home.DuLieu;
using Home.FrmCon.FrmConAdmin.UCThanhPhan;
using Home.FrmCon.FrmCuaAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmConAdmin
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }
        XuLiDuLieu xl = new XuLiDuLieu();
        public void load()
        {
            panelNoiDung.Controls.Clear();
            DataTable dataTable = xl.DoDuLieuNhanVien();

            foreach (DataRow row in dataTable.Rows)
            {
                ONhanVien oNhanVien = new ONhanVien();
                string manhanvien = row["MaNhanVien"].ToString();
                string tennhanvien = row["TenNhanVien"].ToString();
                byte[] imageData = (byte[])row["Anh"];

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image anh = Image.FromStream(ms);
                    string tuoi = row["Tuoi"].ToString();
                    string kinhnghiem = row["KinhNghiem"].ToString();
                    string luong = row["Luong"].ToString();
                    oNhanVien.themThongTin(manhanvien,tennhanvien, tuoi, kinhnghiem, anh, luong);
                    panelNoiDung.Controls.Add(oNhanVien);
                    oNhanVien.BringToFront();
                }
            }
        }
        public void UCNhanVien_Load(object sender, EventArgs e)
        {
           load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frmThemNhanVien = new FrmThemNhanVien();
            frmThemNhanVien.ShowDialog();
        }
    }
}
