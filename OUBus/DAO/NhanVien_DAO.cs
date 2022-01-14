using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUBus.DAO
{
    class NhanVien_DAO
    {
        OuBusEntities1 db;
        public NhanVien_DAO()
        {
            db = new OuBusEntities1();
        }
        public dynamic DanhSachNhanVien()
        {
            var ds = db.NhanViens.Select(s => new { s.MaNhanVien,s.TenNhanVien,s.MaLoaiNhanVien,s.NgaySinh,s.QueQuan,s.CMND}).ToList();
            return ds;
        }
        public dynamic FindEmployeesByEmployeeID(NhanVien nv)
        {
            var ds = db.NhanViens.Where(s => s.MaNhanVien == nv.MaNhanVien).Select(s => new { s.MaNhanVien, s.TenNhanVien, s.MaLoaiNhanVien, s.NgaySinh, s.QueQuan, s.CMND }).ToList();
            return ds;
        }
        public dynamic FindEmployeesByTypeOfEmployeeID(NhanVien nv)
        {
            var ds = db.NhanViens.Where(s => s.MaLoaiNhanVien == nv.MaLoaiNhanVien).Select(s => new { s.MaNhanVien, s.TenNhanVien, s.MaLoaiNhanVien, s.NgaySinh, s.QueQuan, s.CMND }).ToList();
            return ds;
        }
        public dynamic FindEmployeesByEmployeeName(NhanVien nv)
        {
            var ds = db.NhanViens.Where(s => s.TenNhanVien == nv.TenNhanVien).Select(s => new { s.MaNhanVien, s.TenNhanVien, s.MaLoaiNhanVien, s.NgaySinh, s.QueQuan, s.CMND }).ToList();
            return ds;
        }
        public void DeleteEmployee(NhanVien nv)
        {
            db.XoaThongTinNV(nv.MaNhanVien);
            db.SaveChanges();
        }
    }
}
