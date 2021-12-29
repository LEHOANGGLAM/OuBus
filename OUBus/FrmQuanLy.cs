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
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void menuQLCD_Click(object sender, EventArgs e)
        {
        }

        private void menuQLCD_Click_1(object sender, EventArgs e)
        {
            FrmQLCD frmqlcd = new FrmQLCD();
            frmqlcd.MdiParent = this;
            frmqlcd.Show();
        }

        private void menuQLBV_Click(object sender, EventArgs e)
        {
            FrmQLBV frmqlbv = new FrmQLBV();
            frmqlbv.MdiParent = this;
            frmqlbv.Show();
        }

        private void menuDSVX_Click(object sender, EventArgs e)
        {
            FrmDSVX frmdsvx = new FrmDSVX();
            frmdsvx.MdiParent = this;
            frmdsvx.Show();
        }
    }
}
