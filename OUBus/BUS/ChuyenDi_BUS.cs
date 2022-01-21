using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUBus.DAO;

namespace OUBus.BUS
{
    class ChuyenDi_BUS
    {
        VeXe_DAO veXe_DAO;
        ChuyenDi_DAO chuyenDi_DAO;
        XeKhach_DAO xeKhach_DAO;
        public ChuyenDi_BUS()
        {
            veXe_DAO = new VeXe_DAO();
            chuyenDi_DAO = new ChuyenDi_DAO();
            xeKhach_DAO = new XeKhach_DAO();
        }

        //Form Bán Vé
        public dynamic GetListChuyenDi()
        {
            dynamic listCD = chuyenDi_DAO.GetListChuyenDi();
            return listCD;
        }
    
        public ChuyenDi GetChuyenDiByMCD(int MCH)
        {
            ChuyenDi cd = chuyenDi_DAO.FindChuyenDiByMaChuyenDi(MCH);
            return cd;
        }

        public dynamic GetListTKDT(DateTime Ngay1, DateTime Ngay2)
        {
            dynamic tKDT = chuyenDi_DAO.GetListChuyenDiByTKDT(Ngay1, Ngay2);
            return tKDT;
        }

        public void UpdateChuyenDi(ChuyenDi cd)
        {
            try
            {
                if (chuyenDi_DAO.FindChuyenDi(cd.MaChuyenDi) != null)
                {
                    chuyenDi_DAO.UpdateChuyenDi(cd);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật thất bại: Không tồn tại nhân viên");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }

        public void AddChuyenDi(ChuyenDi cd)
        {
            try
            {
                chuyenDi_DAO.AddChuyenDi(cd);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }
    }
}
