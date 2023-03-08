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
    public partial class F_gestaoUsuario : Form
    {
        public F_gestaoUsuario()
        {
            InitializeComponent();
        }

        private void F_gestaoUsuario_Load(object sender, EventArgs e)
        {
            dgv_gestaoUsuario.DataSource = Banco.obterUsuariosIdNome();
            dgv_gestaoUsuario.Columns[0].Width = 85;
            dgv_gestaoUsuario.Columns[1].Width = 190;
        }

        private void dgv_gestaoUsuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.obterDadosUsuario(vid);
                tb_id.Text=dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<String>("T_NOMEUSUARIO");
                tb_username.Text = dt.Rows[0].Field<String>("T_USERNAME");
                tb_senha.Text = dt.Rows[0].Field<String>("T_PASSWORD");
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO");
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
           
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
           
            int linha = dgv_gestaoUsuario.Rows[0].Index;            //capturar a linha selecionada
            Usuario u=new Usuario();
            u.id =Convert.ToInt32( tb_id.Text);
            u.nome=tb_nome.Text;
            u.username=tb_username.Text;
            u.senha=tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel =Convert.ToInt32(Math.Round( n_nivel.Value,0));
            Banco.atualizarUsuario(u);
            //dgv_gestaoUsuario.DataSource = Banco.obterUsuariosIdNome(); 
            //dgv_gestaoUsuario.CurrentCell = dgv_gestaoUsuario[0, linha];
            dgv_gestaoUsuario.CurrentCell.Value=tb_nome.Text;    //essa forma evita de recarregar novamente o metodo obter usuarios

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_usuario f_Usuario = new F_usuario();
            f_Usuario.ShowDialog();
            dgv_gestaoUsuario.DataSource = Banco.obterUsuariosIdNome();

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Banco.excluirUsuario(tb_id.Text);
                dgv_gestaoUsuario.Rows.Remove(dgv_gestaoUsuario.CurrentRow);
            }
            
        }
    }
}
