using Home.FrmCon.FrmCuaAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home;

namespace Home.FrmCon
{
    public class TongForm
    {
        public static SanPham SanPham;
        public static TaiKhoan TaiKhoan;
        public static DonHang DonHang;
        public static SanPhamAdmin SanPhamAdmin;
        public static BaoCao BaoCao;
        public static KhachHang KhachHang;
        public static void ResetFrm()
        {
            TaiKhoan = new TaiKhoan();
            SanPham = new SanPham();
            DonHang = new DonHang();
            SanPhamAdmin = new SanPhamAdmin();
            BaoCao = new BaoCao();
            KhachHang = new KhachHang();
        }
    }
}
