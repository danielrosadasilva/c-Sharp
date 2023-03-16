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
    public partial class F_login : Form
    {
        F_principal form1;    //para acessar elementos de outro form
        
        DataTable dt=new DataTable();
        public F_login(F_principal f)
        {
            InitializeComponent();
            form1 = f;
        }


        private void bt_entrar_Click(object sender, EventArgs e)
        {
            string username=tb_username.Text;
            string password=tb_passord.Text;
            if(username=="" || password == "")
            {
                MessageBox.Show("Campos Invalidos");
                tb_passord.Clear();
                tb_username.Clear();
                tb_username.Focus();
                return;
            }
            string sql = "SELECT * FROM TB_USUARIOS WHERE T_USERNAME='" + username + "'AND T_PASSWORD='" + password+"'" ;
            dt = Banco.dql(sql);
            if(dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();      
                form1.lb_usuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");   //SEGUNDA MANEIRA 
                form1.pb_logado.Image = Properties.Resources.verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                form1.btn_sair.Enabled = true;
                this.Close();
            }
            else
            {
                tb_passord.Clear();
                tb_username.Clear();
                tb_username.Focus();
                MessageBox.Show("usuario não encontrado");

            }
        }
         
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked)
            {
                tb_passord.PasswordChar = '\0';
            }
            else
            {
                tb_passord.PasswordChar = '*';
            }
        }
    }
}
