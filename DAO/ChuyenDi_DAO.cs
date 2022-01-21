using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUBus.DAO
{
    class ChuyenDi_DAO
    {
        OuBusEntities1 db;

        public ChuyenDi_DAO()
        {
            db = new OuBusEntities1();
        }

        public ChuyenDi FindChuyenDiByMaChuyenDi(int maChuyenDi)
        { 
            ChuyenDi cd = db.ChuyenDis.FirstOrDefault(s => s.MaChuyenDi == maChuyenDi);
            return cd;
        }

        public List<ChuyenDi> GetListChuyenDi()
        {
            List<ChuyenDi> listCD = db.ChuyenDis.Select(s => s).OrderBy(s => s.MaXe).ToList();
            return listCD;
        }

        public ChuyenDi FindChuyenDi(int MaChuyenDi)
        {
            ChuyenDi cd = db.ChuyenDis.FirstOrDefault(s => s.MaChuyenDi == MaChuyenDi);
            return cd;
        }

        public void UpdateChuyenDi(ChuyenDi cdNew)
        {
            ChuyenDi cd = FindChuyenDi(cdNew.MaChuyenDi);

            cd.MaChuyenDi = cdNew.MaChuyenDi;
            cd.MaXe = cdNew.MaXe;
            cd.NgayKhoiHanh = cdNew.NgayKhoiHanh;
            cd.ThoiGianKhoiHanh = cdNew.ThoiGianKhoiHanh;
            cd.DiemKhoiHanh = cdNew.DiemKhoiHanh;
            cd.DiemKetThuc = cdNew.DiemKetThuc;
            cd.SoGheTrong = cdNew.SoGheTrong;
            cd.SoGheDat = cdNew.SoGheDat;
            cd.GiaVe = cdNew.GiaVe;
            db.SaveChanges();
        }

        public void AddChuyenDi(ChuyenDi cdNew)
        {
            db.ChuyenDis.Add(cdNew);
            db.SaveChanges();
        }

        public void DeleteChuyenDi(ChuyenDi cdNew)
        {
            ChuyenDi cd = FindChuyenDi(cdNew.MaChuyenDi);
            db.ChuyenDis.Remove(cd);
            db.SaveChanges();
        }

        //TIMKIEM
        public dynamic GetListChuyenDiByTen(string kw)
        {
            var cd = db.TimKiemCD(kw).ToList();
            return cd;
        }

        public dynamic GetListChuyenDiByTKDT(DateTime Ngay1, DateTime Ngay2) 
        {
            var cd = db.pr_TKDT(Ngay1, Ngay2);
            return cd;
        }

    }
}
