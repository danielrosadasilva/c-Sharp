using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class F_usuario : Form
    {
        public F_usuario()
        {
            InitializeComponent();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_senha.Clear();
            tb_username.Clear();
            n_nivel.Value = Convert.ToDecimal(1);
            tb_nome.Focus();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.status = cb_status.Text;
            usuario.senha = tb_senha.Text;
            usuario.username=tb_username.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0)); //Convert.ToInt32(Math.Round(n_nivel.value,0));
            Banco.novoUsuario(usuario);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

            tb_nome.Clear();
            tb_senha.Clear();
            tb_username.Clear();
            n_nivel.Value =1 ;
            bt_novo.Focus();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
