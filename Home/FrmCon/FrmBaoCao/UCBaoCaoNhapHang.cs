using Home.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.FrmCon.FrmBaoCao
{
    public partial class UCBaoCaoNhapHang : UserControl
    {
        SqlConnection conn = null;
        public UCBaoCaoNhapHang()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiCSDL.strconn);
        }
        XuLiDuLieu xl = new XuLiDuLieu();

        
        public void LoadDataToDataGridView()
        {
            DataTable dt = xl.DoDuLieuBaoCaoNhapHang();

            // Kiểm tra xem DataTable có dữ liệu không
            if (dt != null && dt.Rows.Count > 0)
            {
               dgNhapHang.DataSource = dt;
            }
            else
            {  
                MessageBox.Show("Không có dữ liệu để hiển thị!");
            }
        }

        private void UCBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
               
                NhapHang nhapHang = new NhapHang();

           
                nhapHang.SetDatabaseLogon("sa", "123");

               
                nhapHang.SetDataSource(dgNhapHang.DataSource as DataTable);

            
                FrmIn frmIn = new FrmIn();

                
                frmIn.crystalnhaphang.ReportSource = nhapHang;

              
                frmIn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
