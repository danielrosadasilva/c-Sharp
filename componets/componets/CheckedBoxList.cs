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
    public partial class CheckedBoxList : Form
    {
        public CheckedBoxList()
        {
            InitializeComponent();

        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt="";

            if(clb_transportes.CheckedItems.Count>0)
            {
                foreach (string c in clb_transportes.CheckedItems)
                {
                    txt += c + ", ";
                }

                MessageBox.Show(txt);
            }
            else
            {
                MessageBox.Show("Nenhum veiculo está Marcado.");
            }
            
           
           
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            clb_transportes.Items.Add("carro",false);
            clb_transportes.Items.Add("avião", false);
            clb_transportes.Items.Add("onibus",false);
            clb_transportes.Items.Add("trem", false);

        }

        private void btn_novoTransporte_Click(object sender, EventArgs e)
        {

            if(tb_novoTrasporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTrasporte.Text);
                tb_novoTrasporte.Clear();
                tb_novoTrasporte.Focus();
            }
            else
            {
                MessageBox.Show("Campo de Nome Vazio");
            }
            

        }
    }
}
