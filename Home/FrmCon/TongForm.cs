using Home.FrmCon.FrmCuaAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home;
using Home.FrmCon.FrmConAdmin;
using Home.FrmCon.FrmBaoCao;

namespace Home.FrmCon
{
    public class TongForm
    {
        public static SanPham SanPham;
        public static TaiKhoan TaiKhoan;
        public static DonHang DonHang;
        public static SanPhamAdmin SanPhamAdmin;
        public static UCBaoCao UCBaoCao;
        public static KhachHang KhachHang;
        public static ChiTietKH ChiTietKH;
        public static TaiKhoanAdmin TaiKhoanAdmin;
        public static void ResetFrm()
        {
            TaiKhoan = new TaiKhoan();
            SanPham = new SanPham();
            DonHang = new DonHang();
            SanPhamAdmin = new SanPhamAdmin();
            UCBaoCao = new UCBaoCao();
            KhachHang = new KhachHang();
            ChiTietKH = new ChiTietKH();
            TaiKhoanAdmin = new TaiKhoanAdmin();
        }
    }
}
