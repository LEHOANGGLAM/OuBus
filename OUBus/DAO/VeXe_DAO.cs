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

        public List<VeXe> GetListVeXe()
        {
            List<VeXe> listVX = db.VeXes.Select(s => s).ToList();
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
