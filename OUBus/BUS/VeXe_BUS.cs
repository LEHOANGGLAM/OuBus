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
        public VeXe_BUS()
        {
            veXe_DAO = new VeXe_DAO();
        }

        public List<VeXe> GetListVeXe()
        {
            List<VeXe> listVX = veXe_DAO.GetListVeXe();
            return listVX;
        }

        public dynamic GetListMaChuyenDi()
        {
            var ds = veXe_DAO.GetListMaChuyenDi();
            return ds;
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
                    MessageBox.Show("Sửa thất bại: Không tồn tại nhân viên");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
        }

        public void AddVeXe(VeXe vx)
        {
            try
            {
                veXe_DAO.AddVeXe(vx);
                MessageBox.Show("Thêm thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }
        public void DeleteProduct(VeXe vx)
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
