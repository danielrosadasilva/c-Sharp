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
    }
}
