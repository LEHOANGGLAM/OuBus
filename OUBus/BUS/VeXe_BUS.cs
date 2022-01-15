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
    class VeXe_BUS
    {
        VeXe_DAO veXe_DAO;
        ChuyenDi_DAO chuyenDi_DAO;
        XeKhach_DAO xeKhach_DAO;
        public VeXe_BUS()
        {
            veXe_DAO = new VeXe_DAO();
            chuyenDi_DAO = new ChuyenDi_DAO();
            xeKhach_DAO = new XeKhach_DAO();
        }

        //Form Bán Vé
        public dynamic GetListChuyenDi()
        {
            dynamic listVX = veXe_DAO.GetListChuyenDi();
            return listVX;
        }

        public ChuyenDi GetChuyenDiByMCD(int MCH)
        {
            ChuyenDi cd = chuyenDi_DAO.FindChuyenDiByMaChuyenDi(MCH);
            return cd;
        }
        public XeKhach GetXeKhachByMaXe(int MaXe)
        {
            XeKhach xk = xeKhach_DAO.FindXeByMaXe(MaXe);
            return xk;
        }


        //DS Vé Xe
        public List<VeXe> GetListVeXe()
        {
            List<VeXe> listVX = veXe_DAO.GetListVeXe();
            return listVX;
        }
        public List<VeXe> GetListVeXeByMCD(int MCD)
        {
            List<VeXe> listVX = veXe_DAO.GetListVeXeByMCD(MCD);
            return listVX;
        }

        public dynamic GetListMaChuyenDi()
        {
            var ds = veXe_DAO.GetListMaChuyenDi();
            return ds;
        }

        public VeXe GetVeXeByMaVe(int maVe)
        {
            VeXe vx = veXe_DAO.FindVeXe(maVe);
            return vx;
        }
        //BUTTON
        public void UpdateVeXe(VeXe vx)
        {
            try
            {
                if (veXe_DAO.FindVeXe(vx.MaVe) != null)
                {
                    veXe_DAO.UpdateVeXe(vx);
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

        public void AddVeXe(VeXe vx)
        {
            try
            {
                veXe_DAO.AddVeXe(vx);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }
        public void DeleteVeXe(VeXe vx)
        {
            try
            {
                if (veXe_DAO.FindVeXe(vx.MaVe) != null)
                {
                    veXe_DAO.DeleteVeXe(vx);
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xóa thất bại: Không tồn tại nhân viên");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại: \n" + ex.Message);
            }
        }


    }
}
