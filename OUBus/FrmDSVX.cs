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
    public partial class FrmDSVX : Form
    {
        VeXe_BUS veXe_BUS;
        int MaVe = -1;
        public String viTriGhe;
        public FrmDSVX()
        {
            InitializeComponent();
            veXe_BUS = new VeXe_BUS();
        }
        

        private void FrmDSVX_Load(object sender, EventArgs e)
        {
            DGVVeXe.DataSource = veXe_BUS.GetListVeXe();

            cbMaChuyenDi.DataSource = veXe_BUS.GetListMaChuyenDi();
            cbMaChuyenDi.DisplayMember = "MaChuyenDi";
            cbMaChuyenDi.ValueMember = "MaChuyenDi";
        }

        private void DGVVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               txtTenKhachHang.Text = DGVVeXe.Rows[e.RowIndex].Cells["TenKhachHang"].Value == null ? null : DGVVeXe.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
               viTriGhe = DGVVeXe.Rows[e.RowIndex].Cells["ViTriGhe"].Value == null ? null : DGVVeXe.Rows[e.RowIndex].Cells["ViTriGhe"].Value.ToString();
               txtSDT.Text = DGVVeXe.Rows[e.RowIndex].Cells["SoDienThoai"].Value == null ? null : DGVVeXe.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
               cbMaChuyenDi.Text = DGVVeXe.Rows[e.RowIndex].Cells["MaChuyenDi"].Value == null ? null : DGVVeXe.Rows[e.RowIndex].Cells["MaChuyenDi"].Value.ToString();

               MaVe = int.Parse(DGVVeXe.Rows[e.RowIndex].Cells["MaVe"].Value == null ? null : DGVVeXe.Rows[e.RowIndex].Cells["MaVe"].Value.ToString());
               this.txtViTriGhe.Text = viTriGhe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            try
            {
                VeXe vx = veXe_BUS.GetVeXeByMaVe(MaVe);
                vx.TinhTrang = "Bán";

                veXe_BUS.UpdateVeXe(vx);
                this.Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                VeXe vx = veXe_BUS.GetVeXeByMaVe(MaVe);
                vx.MaChuyenDi = int.Parse(cbMaChuyenDi.SelectedValue.ToString());
                vx.TenKhachHang = txtTenKhachHang.Text;
                vx.VitriGhe = txtViTriGhe.Text;
                vx.SoDienThoai = txtSDT.Text;

                veXe_BUS.UpdateVeXe(vx);
                this.Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                VeXe vx = veXe_BUS.GetVeXeByMaVe(MaVe);
                veXe_BUS.DeleteVeXe(vx);
                this.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reset()
        {
            this.txtSDT.Text = "";
            this.txtTenKhachHang.Text = "";
            this.txtTimKiem.Text = "";
            this.txtViTriGhe.Text = "";
            this.DGVVeXe.DataSource = veXe_BUS.GetListVeXe();
        }

        public void ReloadtxtViTriGhe()
        {
            this.txtViTriGhe.Text = viTriGhe;        
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdSDT.Checked)
            {
                //DGVVeXe.DataSource = veXe_BUS.Get
            }else if (rbTen.Checked)
            {

            }else
            {

            }

        }

        private void rbTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btChon_Click(object sender, EventArgs e)
        {
            Ghe f = new Ghe();
            f.MaCD = int.Parse(cbMaChuyenDi.Text);
            f.FrmDSVX = this;
            f.ShowDialog();
        }
    }
}
