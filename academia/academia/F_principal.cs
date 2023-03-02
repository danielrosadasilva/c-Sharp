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
        
    }
}