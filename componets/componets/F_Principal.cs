namespace componets
{
    public partial class F_Principal : Form
    {
       public int num = 0;
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tb_nomeVeiculo.Text == ""){
                MessageBox.Show("campo está vazio!!");
               
            }if (tb_lista.Text.Length==0)
            {
             tb_lista.Text += tb_nomeVeiculo.Text;
            }
            else
            {
                tb_lista.Text += ", " + tb_nomeVeiculo.Text;
           
                                               }
            
            tb_nomeVeiculo.Clear();
            tb_nomeVeiculo.Focus();

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_lista.Clear();
            tb_nomeVeiculo.Clear();
            tb_nomeVeiculo.Focus();
        }

        private void btn_exibirLista_Click(object sender, EventArgs e)
        {
            F_ListaVeiculo f_ListaVeiculo = new F_ListaVeiculo(tb_lista.Text,this);

            f_ListaVeiculo.ShowDialog();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedBoxList checkedListBox = new CheckedBoxList();
            checkedListBox.ShowDialog();    
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.ShowDialog();
            
        }

        private void dateTimePickeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.ShowDialog();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)       // "e" recebe o item clicado,com ele podemos fazer o controles do menu.
        {
            if (e.ClickedItem.Text == cms_restaurar.Text)
            {
                this.WindowState = FormWindowState.Normal;          //windows state conseguimos controlar as janelas minimizar,maximilizar e etc.
            }if(e.ClickedItem.Text == cms_mensagem.Text)
            {
                MessageBox.Show("Mensagem");
            }
            if (e.ClickedItem.Text == cms_fechar.Text)
            {
                this.Close();
            }
            if(e.ClickedItem.Text == cms_minimizar.Text)
            {
                this.WindowState=FormWindowState.Minimized;
            }
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox=new F_PictureBox();
            f_PictureBox.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar=new F_TrackBar();
            f_TrackBar.ShowDialog();
        }
    }
}