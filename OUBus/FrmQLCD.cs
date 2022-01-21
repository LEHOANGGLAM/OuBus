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
        public FrmQLCD(DataGridView dg)
        {
            GVCD = dg;
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
               txtGioKhoiHanh.Text = GVCD.Rows[e.RowIndex].Cells["ThoiGianKhoiHanh"].Value == null ? null : GVCD.Rows[e.RowIndex].Cells["ThoiGianKhoiHanh"].Value.ToString();

               

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
            cd.dt = GVCD;
            cd.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmThemCD cd = new FrmThemCD();
            cd.MaChuyen = int.Parse(GVCD.CurrentRow.Cells[0].Value.ToString());
            cd.MaXe = int.Parse(GVCD.CurrentRow.Cells[1].Value.ToString());
            cd.NgayKH = DateTime.Parse(GVCD.CurrentRow.Cells[2].Value.ToString());
            cd.GioKH = TimeSpan.Parse(GVCD.CurrentRow.Cells[3].Value.ToString());
            cd.DiemKH = GVCD.CurrentRow.Cells[4].Value.ToString();
            cd.DiemKT = GVCD.CurrentRow.Cells[5].Value.ToString();
            cd.SoGheTrong = int.Parse(GVCD.CurrentRow.Cells[6].Value.ToString());
            cd.GiaVe = int.Parse(GVCD.CurrentRow.Cells[8].Value.ToString());
            cd.dt = GVCD;
            cd.ShowDialog();
        }
    }
}
