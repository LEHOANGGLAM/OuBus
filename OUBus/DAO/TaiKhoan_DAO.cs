using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUBus.BUS
{
    class TaiKhoan_DAO
    {
        OuBusEntities1 db;
        public TaiKhoan_DAO()
        {
            db = new OuBusEntities1();
        }
        public dynamic DSQuyen()
        {
            var ds = db.PhanQuyens.Select(s => new { s.MaQuyen, s.TenQuyen }).ToList();
            return ds;
        }
        public dynamic DSNhanVien()
        {
            var ds = db.NhanViens.Select(s => new { s.MaNhanVien, s.TenNhanVien }).ToList();
            return ds;
        }
        public int KiemTraTaiKhoan(TaiKhoanDangNhap tk)
        {
            int kq = 0;
            var ds = db.TaiKhoanDangNhaps.Select(s => s).ToList();
            foreach (var item in ds)
            {
                if (item.TaiKhoan == tk.TaiKhoan)
                {
                    kq = 1;
                    break;
                }
            }
            return kq;
        }
        public void DangKyTaiKhoan(TaiKhoanDangNhap tk)
        {
            db.ThemTaiKhoan(tk.TaiKhoan, tk.MatKhau, tk.MaNhanVien, tk.MaQuyen, tk.HoTen, tk.Email, tk.NgaySinh);
            db.SaveChanges();
        }
        public int KiemTraMatKhau(TaiKhoanDangNhap tk)
        {
            int kq = 0;
            TaiKhoanDangNhap ds = db.TaiKhoanDangNhaps.FirstOrDefault(s => s.TaiKhoan == tk.TaiKhoan);
            if (ds.MatKhau == tk.MatKhau)
                kq = 1;
            return kq;
        }
        public int KiemTraMaQuyen(TaiKhoanDangNhap tk)
        {
            int kq = 0;
            TaiKhoanDangNhap ds = db.TaiKhoanDangNhaps.FirstOrDefault(s => s.TaiKhoan == tk.TaiKhoan);
            if (ds.MaQuyen == tk.MaQuyen)
                kq = 1;
            return kq;
        }
    }
}

