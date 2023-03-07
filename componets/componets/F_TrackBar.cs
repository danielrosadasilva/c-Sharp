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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_valor.Text) < 0)
            {
                MessageBox.Show("valor muito pequeno");
                return;
            }
            if (int.Parse(tb_valor.Text) > 100)
            {
                MessageBox.Show("valor muito grande");
                return ;
            }
            trackBar1.Value =int.Parse(tb_valor.Text);
            lb_valor.Text = tb_valor.Text;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            lb_valor.Text = trackBar1.Value.ToString();
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            lb_valor.Text = trackBar1.Value.ToString();
        }
    }
}
