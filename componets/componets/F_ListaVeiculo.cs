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
    public partial class F_ListaVeiculo :Form
    {
        F_Principal fp;
  
        public F_ListaVeiculo(string lista,F_Principal f) 
        {
            fp = f;   // foi passado a propria classe F_principal.
            
            InitializeComponent();
            tb_exibirLista.Text = lista;
            f.num = 10;
            

            
        }

        private void F_ListaVeiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista.Text=tb_exibirLista.Text; //por padrao os componentes tem a visibilidade private nas propriedades.
            
        }
    }
}
