using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUBus.BUS
{
    class TaiKhoan_BUS
    {
        TaiKhoan_DAO dDangKy;
        public TaiKhoan_BUS()
        {
            dDangKy = new TaiKhoan_DAO();
        }
        public void LayDSQuyen(ComboBox cb)
        {
            cb.DataSource = dDangKy.DSQuyen();
            cb.DisplayMember = "TenQuyen";
            cb.ValueMember = "MaQuyen";
        }
        public void LayDSNhanVien(ComboBox cb)
        {
            cb.DataSource = dDangKy.DSNhanVien();
            cb.DisplayMember = "TenNhanVien";
            cb.ValueMember = "MaNhanVien";
        }
        public int KiemTraTaiKhoan(TaiKhoanDangNhap tk)
        {
            return dDangKy.KiemTraTaiKhoan(tk);
        }
        public int DangKyTaiKhoan(TaiKhoanDangNhap tk)
        {
            int kq = 0;
            try
            {
                dDangKy.DangKyTaiKhoan(tk);
                kq = 1;//Thành Công
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
        public int KiemTraMatKhau(TaiKhoanDangNhap tk)
        {
            return dDangKy.KiemTraMatKhau(tk);
        }
        public int KiemTraMaQuyen(TaiKhoanDangNhap tk)
        {
            return dDangKy.KiemTraMaQuyen(tk);
        }
    }
}

