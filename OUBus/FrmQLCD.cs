using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUBus.BUS;

namespace OUBus
{
    public partial class FrmQLCD : Form
    {
        ChuyenDi_BUS ChuyenDi_BUS;
        public FrmQLCD()
        {
            InitializeComponent();
            ChuyenDi_BUS = new ChuyenDi_BUS();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQLCD_Load(object sender, EventArgs e)
        {
           GVCD.DataSource = ChuyenDi_BUS.GetListChuyenDi();

            cbMaxe.DataSource = ChuyenDi_BUS.GetListChuyenDi();
            cbMaxe.DisplayMember = "MaXe";
            cbMaxe.ValueMember = "Maxe";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void GVCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               txtGiave.Text = GVCD.Rows[e.RowIndex].Cells["GiaVe"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["GiaVe"].Value.ToString();
               txtDiemkhoihanh.Text = GVCD.Rows[e.RowIndex].Cells["DiemKhoiHanh"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["DiemKhoiHanh"].Value.ToString();
               txtDiemketthuc.Text = GVCD.Rows[e.RowIndex].Cells["DiemKetThuc"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["DiemKetThuc"].Value.ToString();
               Thgiankhoihanh.Text = GVCD.Rows[e.RowIndex].Cells["NgayKhoiHanh"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["NgayKhoiHanh"].Value.ToString();
               txtGioKhoiHanh.Text = txtDiemketthuc.Text = GVCD.Rows[e.RowIndex].Cells["ThoiGianKhoiHanh"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["ThoiGianKhoiHanh"].Value.ToString();

               

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnThoat.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemCD cd = new FrmThemCD();
            cd.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmThemCD cd = new FrmThemCD();
            cd.Show();
        }
    }
}
