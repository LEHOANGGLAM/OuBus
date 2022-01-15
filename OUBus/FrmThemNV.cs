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
    public partial class FrmThemNV : Form
    {
        NhanVien_BUS bNhanVien;
        public FrmThemNV()
        {
            InitializeComponent();
            bNhanVien = new NhanVien_BUS();
        }
        public int EmployeeID;
        public string EmployeeName;
        public int EmployeeTypeCode;
        public DateTime? DateOfBirth=null;
        public string Hometown;
        public string CMND;
        public DataGridView dt;
        private int KiemTraCMND(String input)
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
                else if (Char.IsLetter(a) == true)
                    demSoKyTu += 1;
                else if (Char.IsWhiteSpace(a) == true)
                    demKhoangTrang += 1;
            }
            if (demKhoangTrang > 0 || demSoKyTu > 0 || demSoKyTuDB > 0)
            {
                kq = 1;
            }
            return kq;
        }
        private int KiemTraHoTen(String input)
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
                else if (Char.IsLetter(a) == true)
                    demSoKyTu += 1;
                else if (Char.IsWhiteSpace(a) == true)
                    demKhoangTrang += 1;
            }
            if (demSoKySo > 0 || demSoKyTuDB > 0)
            {
                kq = 1;
            }
            return kq;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien NewEmployee = new NhanVien();
            if (textBox2.Text == "")
                MessageBox.Show("Chưa nhập Họ Tên");
            else if (textBox5.Text == "")
                MessageBox.Show("Chưa nhập quê quán");
            else if (textBox7.Text == "")
                MessageBox.Show("Chưa nhập cmnd");
            else
            {
                if (KiemTraHoTen(textBox2.Text) == 1)
                    MessageBox.Show("Sai định dạng họ tên");
                else if (KiemTraCMND(textBox7.Text) == 1)
                    MessageBox.Show("Sai định dạng cmnd");
                else if(KiemTraHoTen(textBox5.Text)==1)
                    MessageBox.Show("Sai định dạng quê quán");
                else
                {
                    NewEmployee.TenNhanVien = textBox2.Text;
                    NewEmployee.QueQuan = textBox5.Text;
                    NewEmployee.CMND = textBox7.Text;
                    NewEmployee.MaLoaiNhanVien = int.Parse(comboBox1.SelectedValue.ToString());
                    NewEmployee.NgaySinh = dateTimePicker1.Value;
                    if (bNhanVien.ThemNV(NewEmployee) == 1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void FrmThemNV_Load(object sender, EventArgs e)
        {
            bNhanVien.LayDSLoaiNhanVien(comboBox1);
            if (EmployeeName == "")
                textBox2.Text = "";
            else
                textBox2.Text = EmployeeName;
            if (EmployeeTypeCode == null)
                comboBox1.SelectedValue = 1;
            else
                comboBox1.SelectedValue = EmployeeTypeCode;
            if (DateOfBirth==null)
                dateTimePicker1.Value = DateTime.Now;
            else
                dateTimePicker1.Value = DateOfBirth.Value;
            if (Hometown == "")
                textBox5.Text = "";
            else
                textBox5.Text = Hometown;
            if (CMND == "")
                textBox7.Text = "";
            else
                textBox7.Text = CMND;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.DataSource = null;
            bNhanVien.LayDSNhanVien(dt);
            dt.Columns[0].Width = (int)(dt.Width * 0.1);
            dt.Columns[1].Width = (int)(dt.Width * 0.2);
            dt.Columns[2].Width = (int)(dt.Width * 0.15);
            dt.Columns[3].Width = (int)(dt.Width * 0.2);
            dt.Columns[4].Width = (int)(dt.Width * 0.2);
            dt.Columns[5].Width = (int)(dt.Width * 0.2);
            FrmQLNV a = new FrmQLNV(dt);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien NewEmployee = new NhanVien();
            if (textBox2.Text == "")
                MessageBox.Show("Chưa nhập Họ Tên");
            else if (textBox5.Text == "")
                MessageBox.Show("Chưa nhập quê quán");
            else if (textBox7.Text == "")
                MessageBox.Show("Chưa nhập cmnd");
            else
            {
                if (KiemTraHoTen(textBox2.Text) == 1)
                    MessageBox.Show("Sai định dạng họ tên");
                else if (KiemTraCMND(textBox7.Text) == 1)
                    MessageBox.Show("Sai định dạng cmnd");
                else if (KiemTraHoTen(textBox5.Text) == 1)
                    MessageBox.Show("Sai định dạng quê quán");
                else
                {
                    NewEmployee.TenNhanVien = textBox2.Text;
                    NewEmployee.QueQuan = textBox5.Text;
                    NewEmployee.CMND = textBox7.Text;
                    NewEmployee.MaLoaiNhanVien = int.Parse(comboBox1.SelectedValue.ToString());
                    NewEmployee.NgaySinh = dateTimePicker1.Value;
                    NewEmployee.MaNhanVien = EmployeeID;
                    if (bNhanVien.SuaNV(NewEmployee) == 1)
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
