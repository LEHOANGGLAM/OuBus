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


    }
}
