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
        List<VeXe> listVX;
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

            btnBan.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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

                btnBan.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                 listVX = new List<VeXe>();
                listVX.AddRange(veXe_BUS.GetListVeXeByMCD(int.Parse(cbMaChuyenDi.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ: SĐT phải đủ 10 số");
                return;
            }
            try
            {
                List<VeXe> listVX = new List<VeXe>();
                listVX.AddRange(veXe_BUS.GetListVeXeByMCD(int.Parse(cbMaChuyenDi.Text)));
                foreach(VeXe ve in listVX)
                    if(ve.VitriGhe.Trim() == txtViTriGhe.Text && ve.MaChuyenDi != int.Parse(cbMaChuyenDi.Text))
                    {
                        MessageBox.Show("Chỗ ngồi đã tồn tại");
                        return;
                    }
           
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
            if (txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ: SĐT phải đủ 10 số");
                return;
            }
            try
            {
                
                foreach (VeXe ve in listVX)
                    if (ve.VitriGhe.Trim() == txtViTriGhe.Text && ve.MaChuyenDi != int.Parse(cbMaChuyenDi.Text))
                    {
                        MessageBox.Show("Chỗ ngồi đã tồn tại");
                        return;
                    }

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
        private void btnXoa_Click(object sender, EventArgs e)
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

    
        private void btChon_Click_1(object sender, EventArgs e)
        {
            Ghe f = new Ghe();
            f.MaCD = int.Parse(cbMaChuyenDi.Text);
            f.FrmDSVX = this;
            f.ShowDialog();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (rdSDT.Checked)
            {
                DGVVeXe.DataSource = veXe_BUS.GetListVeXeBySDT(this.txtTimKiem.Text);
            }
            else if (rbTen.Checked)
            {
                DGVVeXe.DataSource = veXe_BUS.GetListVeXeByTen(this.txtTimKiem.Text);
            }
            else
            {
                DGVVeXe.DataSource = veXe_BUS.GetListVeXeByMCD(this.txtTimKiem.Text);
            }
        }

        private void rbCD_CheckedChanged_1(object sender, EventArgs e)
        {
            DGVVeXe.DataSource = veXe_BUS.GetListVeXeByMCD(this.txtTimKiem.Text);
        }

        private void rbTen_CheckedChanged(object sender, EventArgs e)
        {
            DGVVeXe.DataSource = veXe_BUS.GetListVeXeByTen(this.txtTimKiem.Text);
        }

        private void rdSDT_CheckedChanged_1(object sender, EventArgs e)
        {
            DGVVeXe.DataSource = veXe_BUS.GetListVeXeBySDT(this.txtTimKiem.Text);
        }
    }
}
