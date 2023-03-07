using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componets
{
    public partial class CheckBox : Form
    {
        List<CheckBox> transp=new List<CheckBox>();
        public CheckBox()
        {


            InitializeComponent();
          
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_marcadosCheckbox_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (cb_carro.Checked)
            {
                txt=cb_carro.Text+", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text +", ";
            }
            if (cb_bicicleta.Checked)
            {
                txt+= cb_bicicleta.Text + ", ";
            }
            if (cb_onibus.Checked)
            {
                txt+=cb_onibus.Text + ", ";
            }
            MessageBox.Show(txt);
        }
    }
}
