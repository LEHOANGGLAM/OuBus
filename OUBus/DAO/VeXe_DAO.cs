using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUBus.DAO
{
    class VeXe_DAO
    {
        OuBusEntities1 db;

        public VeXe_DAO()
        {
            db = new OuBusEntities1();
        }
        //Form Bán Vé
        public dynamic GetListChuyenDi()
        {
            dynamic listVX = db.ChuyenDis.Select(s => new {
                s.MaChuyenDi,
                s.DiemKhoiHanh,
                s.DiemKetThuc,
                s.NgayKhoiHanh,
                s.ThoiGianKhoiHanh
            }).ToList();
            return listVX;
        }

        //DS Vé Xe
        public List<VeXe> GetListVeXe()
        {
            List<VeXe> listVX = db.VeXes.Select(s => s).OrderBy(s => s.MaChuyenDi).ToList();
            return listVX;
        }

        public List<VeXe> GetListVeXeByMCD(int MCD)
        {
            List<VeXe> listVX = db.VeXes.Where(s => s.MaChuyenDi == MCD).ToList();
            return listVX;
        }

        public dynamic GetListMaChuyenDi()
        {
            dynamic ds = db.ChuyenDis.Select(s => new
            {
                s.MaChuyenDi,
            }).ToList();
            return ds;
        }

        //BUTTTON
        public VeXe FindVeXe(int MaVe)
        {
            VeXe vx = db.VeXes.FirstOrDefault(s => s.MaVe == MaVe);
            return vx;
        }

        public void UpdateVeXe(VeXe vxNew)
        {
            VeXe vx = FindVeXe(vxNew.MaVe);

            vx.MaChuyenDi = vxNew.MaChuyenDi;
            vx.TenKhachHang = vxNew.TenKhachHang;
            vx.SoDienThoai = vxNew.SoDienThoai;
            vx.VitriGhe = vxNew.VitriGhe;
            vx.TinhTrang = vxNew.TinhTrang;

            db.SaveChanges();
        }

        public void AddVeXe(VeXe vxNew)
        {
            db.VeXes.Add(vxNew);
            db.SaveChanges();
        }

        public void DeleteVeXe(VeXe vxNew)
        {
            VeXe vx = FindVeXe(vxNew.MaVe);
            db.VeXes.Remove(vx);
            db.SaveChanges();
        }



    }
}
