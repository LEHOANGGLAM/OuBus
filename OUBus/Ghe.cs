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
    public partial class Ghe : Form
    {
        public int MaCD;
        List<RadioButton> listRB;
        List<VeXe> listVX;
        VeXe_BUS veXe_BUS;
        public FrmDSVX FrmDSVX;
        public Ghe()
        {
            InitializeComponent();
            veXe_BUS = new VeXe_BUS();
            RadioButton[] array = { rd1, rd2, rd3, rd4, rd5, rd6, rd7, rd8, rd9, rd10, rd11 ,rd12,
                rd13,rd14,rd15,rd16,rd17,rd18,rd19,rd20,rd21,rd22,rd23,rd24,rd25,rd26,rd27,rd28 };
            listRB = new List<RadioButton>(array);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rd in listRB)
                if (rd.Checked)
                {
                    FrmDSVX.viTriGhe = rd.Text;
                    FrmDSVX.ReloadtxtViTriGhe();
                }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ghe_Load(object sender, EventArgs e)
        {
            listVX = new List<VeXe>();
            listVX.AddRange(veXe_BUS.GetListVeXeByMCD(MaCD));
            foreach (VeXe ve in listVX)
                foreach (RadioButton rd in listRB)
                    if (rd.Text == ve.VitriGhe.ToString().Trim())
                        rd.Enabled = false;
        }
    }
}
