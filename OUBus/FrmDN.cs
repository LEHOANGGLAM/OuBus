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
        public FormDN()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void FormDN_Load(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (cbChon.SelectedItem == "Nhân Viên")
            {
                FrmNhanVien nv = new FrmNhanVien();
                nv.ShowDialog();
                this.Close();
            }
            else
            {
                FrmQuanLy ql = new FrmQuanLy();
                ql.ShowDialog();
                this.Close();
            }
        }

        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKi dk = new FrmDangKi();
            dk.ShowDialog();
            this.Close();
        }
    }
}
