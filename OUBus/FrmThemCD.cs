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
    public partial class FrmThemCD : Form
    {
        ChuyenDi_BUS ChuyenDi_BUS;
        
        public FrmThemCD()
        {
            InitializeComponent();
            ChuyenDi_BUS = new ChuyenDi_BUS();
        }
        public int MaChuyen = 0;
        public int MaXe = 0;
        public DateTime? NgayKH = null;
        public TimeSpan GioKH;
        public string DiemKH;
        public string DiemKT;
        public int SoGheTrong=0;
        public int SoGheDat=0;
        public int GiaVe;
        public DataGridView dt;
        private void FrmThemCD_Load(object sender, EventArgs e)
        {
            try
            {
                cbMX.DataSource = ChuyenDi_BUS.GetListChuyenDi();
                cbMX.DisplayMember = "MaXe";
                cbMX.ValueMember = "Maxe";
            }
            catch (NullReferenceException) { }
            if (MaXe == 0)
                cbMX.SelectedValue = 1;
            else
                cbMX.SelectedValue = MaXe;
            if (NgayKH == null)
                dateTimePicker1.Value = DateTime.Now;
            else
                dateTimePicker1.Value = NgayKH.Value;
            if (DiemKH == "")
                txtDKH.Text = "";
            else
                txtDKH.Text = DiemKH;
            if (DiemKT == "")
                txtDKT.Text = "";
            else
                txtDKT.Text = DiemKT;
            if (GioKH == null)
                txtTGKH.Text = "";
            else
                txtTGKH.Text = GioKH.ToString();
            if (SoGheTrong == 0)
                txtSGT.Text = "";
            else
                txtSGT.Text = SoGheTrong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dt.DataSource=ChuyenDi_BUS.GetListChuyenDi();
            FrmQLCD a = new FrmQLCD(dt);
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenDi NewChuyenDi = new ChuyenDi();
            if (cbMX.SelectedIndex > -1)
            {
                if (txtTGKH.Text == "")
                    MessageBox.Show("Chưa nhập Thời Gian Khởi Hành");
                else if (txtDKH.Text == "")
                    MessageBox.Show("Chưa nhập điểm khởi hành");
                else if (txtDKT.Text == "")
                    MessageBox.Show("Chưa nhập điểm kết thúc");
                else if (txtSGT.Text == "")
                    MessageBox.Show("Chưa nhập số ghế trống");
                else if (txtGV.Text == "")
                    MessageBox.Show("Chưa nhập giá vé");
                else
                {
                        NewChuyenDi.MaXe = int.Parse(cbMX.SelectedValue.ToString());
                        NewChuyenDi.NgayKhoiHanh = dateTimePicker1.Value;
                        NewChuyenDi.ThoiGianKhoiHanh =  TimeSpan.Parse(txtTGKH.Text);
                        NewChuyenDi.DiemKhoiHanh = txtDKH.Text;
                        NewChuyenDi.DiemKetThuc = txtDKT.Text;
                        NewChuyenDi.SoGheTrong = int.Parse(txtSGT.Text);
                        NewChuyenDi.SoGheDat = 0;
                        NewChuyenDi.GiaVe = int.Parse(txtGV.Text);

                        ChuyenDi_BUS.AddChuyenDi(NewChuyenDi);    
                        MessageBox.Show("Thêm thành công");
                        
                  
                }
            }
            else
                MessageBox.Show("Bạn chuyển đến từ Sửa không thể Thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChuyenDi NewChuyenDi = new ChuyenDi();
            if (cbMX.SelectedIndex > -1)
            {
                if (txtTGKH.Text == "")
                    MessageBox.Show("Chưa nhập Thời Gian Khởi Hành");
                else if (txtDKH.Text == "")
                    MessageBox.Show("Chưa nhập điểm khởi hành");
                else if (txtDKT.Text == "")
                    MessageBox.Show("Chưa nhập điểm kết thúc");
                else if (txtSGT.Text == "")
                    MessageBox.Show("Chưa nhập số ghế trống");
                else if (txtGV.Text == "")
                    MessageBox.Show("Chưa nhập giá vé");
                else
                {
                    NewChuyenDi.MaChuyenDi = MaChuyen;
                    NewChuyenDi.MaXe = int.Parse(cbMX.SelectedValue.ToString());
                    NewChuyenDi.NgayKhoiHanh = dateTimePicker1.Value;
                    NewChuyenDi.ThoiGianKhoiHanh = TimeSpan.Parse(txtTGKH.Text);
                    NewChuyenDi.DiemKhoiHanh = txtDKH.Text;
                    NewChuyenDi.DiemKetThuc = txtDKT.Text;
                    NewChuyenDi.SoGheTrong = int.Parse(txtSGT.Text);
                    NewChuyenDi.SoGheDat = 0;
                    NewChuyenDi.GiaVe = int.Parse(txtGV.Text);
                    ChuyenDi_BUS.UpdateChuyenDi(NewChuyenDi);

                    MessageBox.Show("Sửa thành công");


                }
            }
        }
    }
}
