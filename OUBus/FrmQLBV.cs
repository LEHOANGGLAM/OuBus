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
    public partial class FrmQLBV : Form
    {
        VeXe_BUS veXe_BUS;
        int MaNv = 6;
        ChuyenDi cd;
        XeKhach xk;
        List<VeXe> listVX;
        List<CheckBox> listCB;
        public FrmQLBV()
        {
            InitializeComponent();
            veXe_BUS = new VeXe_BUS();
        }
        private void FrmQLBV_Load(object sender, EventArgs e)
        {
            DGVChuyenDi.DataSource = veXe_BUS.GetListChuyenDi();
            CheckBox[] array = { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11 ,c12,
                c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28 };
            listCB = new List<CheckBox>(array);
            foreach (CheckBox rd in listCB)
                rd.Enabled = false;
        }

        private void DGVChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaChuyenDi.Text = DGVChuyenDi.Rows[e.RowIndex].Cells["MaChuyenDi"].Value == null ? null : DGVChuyenDi.Rows[e.RowIndex].Cells["MaChuyenDi"].Value.ToString();
                cd = veXe_BUS.GetChuyenDiByMCD(int.Parse(txtMaChuyenDi.Text));
                txtMaXe.Text = cd.MaXe.ToString();
                xk = veXe_BUS.GetXeKhachByMaXe(int.Parse(txtMaXe.Text));
                txtBienSoXe.Text = xk.BienSoXe.ToString();
                txtThoiGianKhoiHanh.Text = cd.NgayKhoiHanh.ToString() + " " + cd.ThoiGianKhoiHanh.ToString();
                txtGiaVe.Text = cd.GiaVe.ToString();
                txtDiemKhoiHanh.Text = cd.DiemKhoiHanh.ToString();
                txtDiemKetThuc.Text = cd.DiemKetThuc.ToString();

                listVX = new List<VeXe>();
                listVX.AddRange(veXe_BUS.GetListVeXeByMCD(int.Parse(txtMaChuyenDi.Text)));

                foreach (CheckBox rd in listCB)
                    rd.Enabled = true;
                foreach (VeXe ve in listVX)
                    foreach (CheckBox rd in listCB)
                        if (rd.Text == ve.VitriGhe.ToString().Trim())
                            rd.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDatve_Click(object sender, EventArgs e)
        {
            string[] vitrigheArray = this.txtViTriGhe.Text.Split(',');
            try
            {
                for (int i = 0; i < vitrigheArray.Length - 1; i++)
                {

                    VeXe vx = new VeXe();
                    vx.MaChuyenDi = int.Parse(txtMaChuyenDi.Text);
                    vx.TenKhachHang = txtTen.Text;
                    vx.VitriGhe = vitrigheArray[i];
                    vx.SoDienThoai = txtSDT.Text;
                    vx.MaNhanVien = MaNv;
                    vx.NgayDat = DateTime.Now;
                    vx.TinhTrang = "Đặt";

                    veXe_BUS.AddVeXe(vx);
                }
                MessageBox.Show("Cập nhật thành công " + (vitrigheArray.Length - 1).ToString() + " vé");
                this.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBanve_Click(object sender, EventArgs e)
        {
            string[] vitrigheArray = this.txtViTriGhe.Text.Split(',');
            try
            {
                for (int i = 0; i < vitrigheArray.Length - 1; i++)
                {
                    VeXe vx = new VeXe();
                    vx.MaChuyenDi = int.Parse(txtMaChuyenDi.Text);
                    vx.TenKhachHang = txtTen.Text;
                    vx.VitriGhe = vitrigheArray[i];
                    vx.SoDienThoai = txtSDT.Text;
                    vx.MaNhanVien = MaNv;
                    vx.NgayDat = DateTime.Now;
                    vx.TinhTrang = "Bán";

                    veXe_BUS.AddVeXe(vx);
                }
                MessageBox.Show("Cập nhật thành công " + (vitrigheArray.Length - 1).ToString() + " vé");
                this.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Reset()
        {
            this.txtMaChuyenDi.Text = "";
            this.txtMaXe.Text = "";
            this.txtBienSoXe.Text = "";
            this.txtThoiGianKhoiHanh.Text = "";
            this.txtGiaVe.Text = "";
            this.txtDiemKhoiHanh.Text = "";
            this.txtDiemKetThuc.Text = "";
            this.txtSDT.Text = "";
            this.txtTen.Text = "";
            this.txtViTriGhe.Text = "";
            this.txtTimKiem.Text = "";
            this.DGVChuyenDi.DataSource = veXe_BUS.GetListChuyenDi();
            foreach (CheckBox rd in listCB)
                rd.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
                this.txtViTriGhe.Text += cb.Text + " ,";
            else
            {
                this.txtViTriGhe.Text.IndexOf(cb.Text);
                this.txtViTriGhe.Text = this.txtViTriGhe.Text.Replace(cb.Text + " ,", "");
            }
        }
    }
}
