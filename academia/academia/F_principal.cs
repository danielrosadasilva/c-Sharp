namespace academia
{
    public partial class F_principal : Form
    {
        
        public F_principal()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
            
           
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login=new F_login(this);
            f_login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "voce deseja sair?";
            string caption = "Aviso!!!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
              return; //fechar o form
            }if(result == DialogResult.Yes)
            {
                lb_acesso.Text = "0";
                lb_usuario.Text = "...";
                pb_logado.Image = Properties.Resources.vermelho;
                Globais.nivel = 0;
                Globais.logado = false;
            }
            
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 3)
                {
                    //
                }
                else
                {
                    MessageBox.Show("Acesso N�o Permitido");
                }
            }
            else
            {
                MessageBox.Show("Precisa est� Logado");
            }
        }

        private void gest�oDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 3)
                {
                    //
                }
                else
                {
                    MessageBox.Show("Acesso N�o Permitido");
                }
            }
            else
            {
                MessageBox.Show("Precisa est� Logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_usuario  f_Usuario = new F_usuario();
                    f_Usuario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso N�o Permitido");
                }
            }
            else
            {
                MessageBox.Show("Precisa est� Logado");
            }
        }

        private void gest�oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 3)
                {
                    F_gestaoUsuario f_GestaoUsuario = new F_gestaoUsuario();
                    f_GestaoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso N�o Permitido");
                }
            }
            else
            {
                MessageBox.Show("Precisa est� Logado");
            }
        }
    }
}