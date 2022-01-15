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
    public partial class FrmQLNV : Form
    {
        NhanVien_BUS bNhanVien;
        public FrmQLNV()
        {
            InitializeComponent();
            bNhanVien = new NhanVien_BUS();
        }
        public FrmQLNV(DataGridView dt)
        {
            dataGridView1 = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNV frmthem = new FrmThemNV();
            frmthem.ShowDialog();
        }
        private void KichThuocGridView()
        {
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.1);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.15);
            dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[4].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[5].Width = (int)(dataGridView1.Width * 0.2);
        }
        public void FrmQLNV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            bNhanVien.LayDSNhanVien(dataGridView1);
            KichThuocGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NhanVien findEmployee = new NhanVien();
            if(textBox1.Text=="")
            {
                dataGridView1.DataSource = null;
                bNhanVien.LayDSNhanVien(dataGridView1);
                KichThuocGridView();
            }
            else if(textBox1.Text!="" && radioButton1.Checked)
            {
                int demKytu = 0;
                foreach(char item in textBox1.Text)
                {
                    if (Char.IsLetter(item))
                        demKytu++;
                }
                if (demKytu > 0)
                {
                    MessageBox.Show("Mã Nhân Viên phải là 1 số");
                    textBox1.Text = "";
                }
                else
                {
                    findEmployee.MaNhanVien = int.Parse(textBox1.Text);
                    dataGridView1.DataSource = null;
                    bNhanVien.FindByEmployeeID(dataGridView1, findEmployee);
                    KichThuocGridView();
                }
            }
            else if (textBox1.Text != "" && radioButton2.Checked)
            {
                int demKytu = 0;
                foreach (char item in textBox1.Text)
                {
                    if (Char.IsLetter(item))
                        demKytu++;
                }
                if (demKytu > 0)
                {
                    MessageBox.Show("Mã Loại Nhân Viên phải là 1 số");
                    textBox1.Text = "";
                }
                else
                {
                    findEmployee.MaLoaiNhanVien = int.Parse(textBox1.Text);
                    dataGridView1.DataSource = null;
                    bNhanVien.FindByTypeOfEmployeeID(dataGridView1, findEmployee);
                    KichThuocGridView();
                }
            }
            else if (textBox1.Text != "" && radioButton3.Checked)
            {
                int demKyso = 0;
                foreach (char item in textBox1.Text)
                {
                    if (Char.IsDigit(item))
                        demKyso++;
                }
                if (demKyso > 0)
                {
                    MessageBox.Show("Không đc nhập số");
                    textBox1.Text = "";
                }
                else
                {
                    findEmployee.TenNhanVien = textBox1.Text;
                    dataGridView1.DataSource = null;
                    bNhanVien.FindByEployeeName(dataGridView1, findEmployee);
                    KichThuocGridView();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (nv.MaNhanVien == null)
                MessageBox.Show("Chưa chọn nhân viên để xóa");
            else
            {
                if (bNhanVien.delEmployee(nv) == -1)
                    MessageBox.Show("EmployeeID isn't exists in database");
                else if (bNhanVien.delEmployee(nv) == 1)
                {
                    MessageBox.Show("Xóa Thành Công");
                    dataGridView1.DataSource = null;
                    bNhanVien.LayDSNhanVien(dataGridView1);
                    KichThuocGridView();
                }
                else if(bNhanVien.delEmployee(nv)==0)
                    MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmThemNV frmthem = new FrmThemNV();
            frmthem.EmployeeID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmthem.EmployeeName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmthem.EmployeeTypeCode = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            frmthem.DateOfBirth = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            frmthem.Hometown = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmthem.CMND = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmthem.dt = dataGridView1;
            frmthem.ShowDialog();
        }
    }
}
