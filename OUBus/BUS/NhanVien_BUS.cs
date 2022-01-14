using OUBus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUBus.BUS
{
    class NhanVien_BUS
    {
        NhanVien_DAO dNhanVien;
        public NhanVien_BUS()
        {
            dNhanVien = new NhanVien_DAO();
        }
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = dNhanVien.DanhSachNhanVien();

        }
        public void FindByEmployeeID(DataGridView dg,NhanVien nv)
        {
            dg.DataSource = dNhanVien.FindEmployeesByEmployeeID(nv);
        }
        public void FindByTypeOfEmployeeID(DataGridView dg, NhanVien nv)
        {
            dg.DataSource = dNhanVien.FindEmployeesByTypeOfEmployeeID(nv);
        }
        public void FindByEployeeName(DataGridView dg, NhanVien nv)
        {
            dg.DataSource = dNhanVien.FindEmployeesByEmployeeName(nv);
        }
        public int delEmployee(NhanVien nv)
        {
            int kq = 0;
            try
            {
                dNhanVien.DeleteEmployee(nv);
                kq = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
    }
}
