using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUBus.DAO
{
    class XeKhach_DAO
    {
        OuBusEntities1 db;

        public XeKhach_DAO()
        {
            db = new OuBusEntities1();
        }

        public XeKhach FindXeByMaXe(int maXe)
        {
            XeKhach cd = db.XeKhaches.FirstOrDefault(s => s.MaXe == maXe);
            return cd;
        }
    }
}
