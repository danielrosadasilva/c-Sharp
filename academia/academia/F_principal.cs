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
        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso Não Permitido");
                }
            }
            else
            {
                MessageBox.Show("Precisa está Logado");
            }
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
                btn_sair.Enabled = false;
            }
            
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abreForm();
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             F_gestaoUsuario f_GestaoUsuario = new F_gestaoUsuario();
             abreForm(3, f_GestaoUsuario);

        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             F_usuario  f_Usuario = new F_usuario();
             abreForm(1, f_Usuario);
        }
        private void gestaoAlunosMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_horarios f_Horarios=new F_horarios();
            abreForm(2, f_Horarios);
        }
    }
}