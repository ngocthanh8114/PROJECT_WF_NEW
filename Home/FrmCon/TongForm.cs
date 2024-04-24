using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Home.FrmCon
{
    public class TongForm
    {
        public static SanPham SanPham;
        public static TaiKhoan TaiKhoan;
        public static DonHang DonHang;
        public static SanPhamAdmin SanPhamAdmin;
        public static BaoCao BaoCao;
        public static void ResetFrm()
        {
            TaiKhoan = new TaiKhoan();
            SanPham = new SanPham();
            DonHang = new DonHang();
            SanPhamAdmin = new SanPhamAdmin();
            BaoCao = new BaoCao();
        }
    }
}
