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
    public partial class FrmTKDT : Form
    {
        ChuyenDi_BUS ChuyenDi_BUS;    
        public FrmTKDT()
        {
            InitializeComponent();
            ChuyenDi_BUS = new ChuyenDi_BUS();
        }

        private void FrmTKDT_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ChuyenDi_BUS.GetListTKDT(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ChuyenDi_BUS.GetListTKDT(dateTimePicker1.Value, dateTimePicker2.Value);

        }
    }
}
