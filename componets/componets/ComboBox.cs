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
    public partial class ComboBox : Form
    {

        public ComboBox()
        {
            InitializeComponent();
           
            
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            if(cb_veiculos.SelectedIndex <0)
            {
                MessageBox.Show("selecione um veiculo na lista!!");
            }
            else
            {
                MessageBox.Show(cb_veiculos.Text);
            }
           
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_adicionar.Focus();
            cb_veiculos.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            cb_veiculos.Items.Add("Carro");
            cb_veiculos.Items.Add("Avião");
            cb_veiculos.Items.Add("Onibus");
            cb_veiculos.Items.Add("Metro");
            tb_adicionar.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_adicionar.Text != "")
            {
                string txt = tb_adicionar.Text;
                if (cb_veiculos.FindStringExact(tb_adicionar.Text) < 0)//procura se a string já existe no combobox
                {
                    cb_veiculos.Items.Add(tb_adicionar.Text);
                }
                else { MessageBox.Show("já existe,impossivel adicionar!!"); }
            } 
            else
            {
                MessageBox.Show("Campo Vazio");
            }
          
        }

        private void cb_veiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_adicionar.Text = cb_veiculos.Text;
        }
    }
}
