using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

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
        public int KiemTraMaNV(NhanVien nv)
        {
            int kq = 0;
            var ds = db.NhanViens.Select(s => s).ToList();
            foreach(var item in ds)
            {
                if (item.MaNhanVien == nv.MaNhanVien)
                {
                    kq = 1;
                    break;
                }
            }
            return kq;
        }
        public void InsertNewEmployee(NhanVien nv)
        {
            db.ThemThongTinNV(nv.MaLoaiNhanVien, nv.TenNhanVien, nv.NgaySinh, nv.QueQuan, int.Parse(nv.CMND));
            db.SaveChanges();
        }
        public void UpdateEmployee(NhanVien nv)
        {
            db.SuaThongTinNV(nv.MaNhanVien, nv.MaLoaiNhanVien, nv.TenNhanVien, nv.NgaySinh, nv.QueQuan, int.Parse(nv.CMND));
            db.SaveChanges();
        }
        public dynamic DSLoaiNV()
        {
            var ds = db.PhanLoaiNhanViens.Select(s => new { s.MaLoaiNhanVien, s.TenLoaiNhanVien }).ToList();
            return ds;
        }
    }
}
