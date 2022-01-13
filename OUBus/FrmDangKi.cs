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
    public partial class FrmDangKi : Form
    {
        TaiKhoan_BUS bDangKy;
        public FrmDangKi()
        {
            InitializeComponent();
            bDangKy = new TaiKhoan_BUS();
        }
        private int DinhDangMail()
        {
            int kq = 0;
            int a = txtEmail.Text.IndexOf("@");
            string b = "@ou.edu.vn";
            if (txtEmail.Text.Substring(a + 1) != b)
            {
                kq = 1;
            }
            return kq;
        }
        private int KiemTra(String input)
        {
            int demSoKyTuDB = 0, DoDaiChuoi = 0, demSoKySo = 0, demSoKyTu = 0, demKhoangTrang = 0;
            int kq = 0;
            foreach (char a in input)
            {
                DoDaiChuoi += 1;
                if (Char.IsSymbol(a) == true)
                    demSoKyTuDB += 1;
                else if (Char.IsNumber(a) == true)
                    demSoKySo += 1;
                else if (Char.IsNumber(a) == false && Char.IsSymbol(a) == false)
                    demSoKyTu += 1;
                else if (Char.IsWhiteSpace(a) == true)
                    demKhoangTrang += 1;
            }
            if (demSoKySo == DoDaiChuoi || demSoKyTuDB > 0 || demSoKyTu == DoDaiChuoi || demKhoangTrang > 0)
                kq = 1;//Sai định dạng UserName
            else if (demSoKySo == DoDaiChuoi || demSoKyTuDB == DoDaiChuoi || demSoKyTu == DoDaiChuoi || demKhoangTrang > 0)
                kq = 2;//Sai định dạng Pass
            else if (demKhoangTrang > 0 || demSoKySo > 0 || demSoKyTuDB > 0)
                kq = 3;

            return kq;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap NewUser = new TaiKhoanDangNhap();
            if (txtUserName.Text == "")
                MessageBox.Show("Nhập Tài Khoản");
            else if (txtPassWord.Text == "")
                MessageBox.Show("Nhập mật khẩu");
            else if (txtRetypePass.Text == "")
                MessageBox.Show("Nhập lại mật khẩu");
            else if (txtEmail.Text == "")
                MessageBox.Show("Nhập mail");
            else if (txtPhone.Text == "")
                MessageBox.Show("Nhập SDT");
            else
            {
                if (KiemTra(txtPassWord.Text) == 2)
                    MessageBox.Show("Sai định dạng mật khẩu!!!");
                else if (KiemTra(txtUserName.Text) == 1)
                    MessageBox.Show("Sai định dạng tài khoản!!!");
                else if (KiemTra(txtPhone.Text) == 3)
                    MessageBox.Show("Sai định dạng SDT!!!");
                else
                {
                    if (txtPassWord.Text == txtRetypePass.Text)
                    {
                        if (DinhDangMail() == 1)
                            MessageBox.Show("Sai định dạng mail");
                        else
                        {
                            NewUser.MatKhau = txtPassWord.Text;
                            NewUser.HoTen = cbMaNV.Text;
                            NewUser.TaiKhoan = txtUserName.Text;
                            NewUser.MatKhau = txtPassWord.Text;
                            NewUser.NgaySinh = dtDateOfBirth.Value;
                            NewUser.MaQuyen = int.Parse(cbMaQuyen.SelectedValue.ToString());
                            NewUser.Email = txtEmail.Text;
                            NewUser.MaNhanVien = int.Parse(cbMaNV.SelectedValue.ToString());
                            if (bDangKy.KiemTraTaiKhoan(NewUser) == 1)
                            {
                                MessageBox.Show("Tài Khoản đã tồn tại");
                            }
                            else
                            {
                                if (bDangKy.DangKyTaiKhoan(NewUser) == 1)
                                    MessageBox.Show("Đăng Ký Thành Công");
                                else
                                    MessageBox.Show("Đăng Ký Thất bại");
                            }
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu không khớp");
                }
            }
        }

        private void FrmDangKi_Load(object sender, EventArgs e)
        {
            bDangKy.LayDSNhanVien(cbMaNV);
            bDangKy.LayDSQuyen(cbMaQuyen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
