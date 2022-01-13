using OUBus.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUBus
{
    public partial class FormDN : Form
    {
        TaiKhoan_BUS bDangKy;
        public FormDN()
        {
            InitializeComponent();
            bDangKy = new TaiKhoan_BUS();
        }

        private void FormDN_Load(object sender, EventArgs e)
        {
            bDangKy.LayDSQuyen(cbChon);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap DangNhap = new TaiKhoanDangNhap();
            if (txtDangNhap.Text == "")
                MessageBox.Show("Chưa nhập tài khoản");
            else if (txtMatKhau.Text == "")
                MessageBox.Show("Chưa nhập tài khoản");
            else
            {
                DangNhap.TaiKhoan = txtDangNhap.Text;
                DangNhap.MatKhau = txtMatKhau.Text;
                DangNhap.MaQuyen = int.Parse(cbChon.SelectedValue.ToString());
                if (bDangKy.KiemTraTaiKhoan(DangNhap) == 0)
                    MessageBox.Show("Tài Khoản không tồn tại");
                else if (bDangKy.KiemTraMatKhau(DangNhap) == 0)
                    MessageBox.Show("Sai mật khẩu ");
                else if (bDangKy.KiemTraMaQuyen(DangNhap) == 0)
                    MessageBox.Show("Chọn sai quyền truy cập");
                else
                {
                    if (DangNhap.MaQuyen == 1)
                    {
                        FrmNhanVien a = new FrmNhanVien();
                        a.ShowDialog();
                    }
                    else if (DangNhap.MaQuyen == 2)
                    {
                        FrmQuanLy a = new FrmQuanLy();
                        a.ShowDialog();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKi dk = new FrmDangKi();
            dk.ShowDialog();
        }
    }
}
