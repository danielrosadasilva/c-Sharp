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
            lb_acesso.Text = "0";
            lb_usuario.Text = "...";   
            pb_logado.Image = Properties.Resources.vermelho;
            Globais.nivel =0 ;
            Globais.logado = false;
        }
    }
}