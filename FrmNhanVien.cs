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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void quảnLýVéXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSVX frmdsvx = new FrmDSVX();
            frmdsvx.MdiParent = this;
            frmdsvx.Show();
        }

        private void quảnLýBánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLBV frmqlbv = new FrmQLBV();
            frmqlbv.MdiParent = this;
            frmqlbv.MaNv = 5;
            frmqlbv.Show();
        }
    }
}
