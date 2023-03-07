namespace componets
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.tb_nomeVeiculo = new System.Windows.Forms.TextBox();
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exibirLista = new System.Windows.Forms.Button();
            this.btn_num = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_minimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(5, 267);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(236, 23);
            this.bt_limpar.TabIndex = 0;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // tb_nomeVeiculo
            // 
            this.tb_nomeVeiculo.Location = new System.Drawing.Point(2, 63);
            this.tb_nomeVeiculo.Name = "tb_nomeVeiculo";
            this.tb_nomeVeiculo.Size = new System.Drawing.Size(155, 23);
            this.tb_nomeVeiculo.TabIndex = 1;
            // 
            // tb_lista
            // 
            this.tb_lista.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lista.Location = new System.Drawing.Point(5, 91);
            this.tb_lista.Multiline = true;
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.ReadOnly = true;
            this.tb_lista.ShortcutsEnabled = false;
            this.tb_lista.Size = new System.Drawing.Size(236, 170);
            this.tb_lista.TabIndex = 2;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(163, 62);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 3;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um Nome de Veiculo:";
            // 
            // btn_exibirLista
            // 
            this.btn_exibirLista.Location = new System.Drawing.Point(5, 296);
            this.btn_exibirLista.Name = "btn_exibirLista";
            this.btn_exibirLista.Size = new System.Drawing.Size(235, 23);
            this.btn_exibirLista.TabIndex = 5;
            this.btn_exibirLista.Text = "Exibir Lista";
            this.btn_exibirLista.UseVisualStyleBackColor = true;
            this.btn_exibirLista.Click += new System.EventHandler(this.btn_exibirLista_Click);
            // 
            // btn_num
            // 
            this.btn_num.Location = new System.Drawing.Point(5, 325);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(233, 23);
            this.btn_num.TabIndex = 6;
            this.btn_num.Text = "valor num";
            this.btn_num.UseVisualStyleBackColor = true;
            this.btn_num.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.locaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickeToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.trackBarToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "CheckBox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickeToolStripMenuItem
            // 
            this.dateTimePickeToolStripMenuItem.Name = "dateTimePickeToolStripMenuItem";
            this.dateTimePickeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickeToolStripMenuItem.Text = "dateTimePicker";
            this.dateTimePickeToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickeToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_restaurar,
            this.cms_mensagem,
            this.cms_fechar,
            this.cms_minimizar});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(134, 92);
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // cms_restaurar
            // 
            this.cms_restaurar.Name = "cms_restaurar";
            this.cms_restaurar.Size = new System.Drawing.Size(133, 22);
            this.cms_restaurar.Text = "Restaurar";
            // 
            // cms_mensagem
            // 
            this.cms_mensagem.Name = "cms_mensagem";
            this.cms_mensagem.Size = new System.Drawing.Size(133, 22);
            this.cms_mensagem.Text = "Mensagem";
            // 
            // cms_fechar
            // 
            this.cms_fechar.Name = "cms_fechar";
            this.cms_fechar.Size = new System.Drawing.Size(133, 22);
            this.cms_fechar.Text = "Fechar";
            // 
            // cms_minimizar
            // 
            this.cms_minimizar.Name = "cms_minimizar";
            this.cms_minimizar.Size = new System.Drawing.Size(133, 22);
            this.cms_minimizar.Text = "Minimizar";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Menu;
            this.notifyIcon1.Text = "Sistema de veiculos";
            this.notifyIcon1.Visible = true;
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 358);
            this.Controls.Add(this.btn_num);
            this.Controls.Add(this.btn_exibirLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.tb_lista);
            this.Controls.Add(this.tb_nomeVeiculo);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Lista de Veiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_limpar;
        private TextBox tb_nomeVeiculo;
        private Button bt_adicionar;
        private Label label1;
        private Button btn_exibirLista;
        private Button btn_num;
        public TextBox tb_lista;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem checkboxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem locaçãoToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickeToolStripMenuItem;
        private ContextMenuStrip Menu;
        private ToolStripMenuItem cms_restaurar;
        private ToolStripMenuItem cms_mensagem;
        private ToolStripMenuItem cms_fechar;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem cms_minimizar;
        private ToolStripMenuItem pictureBoxToolStripMenuItem;
        private ToolStripMenuItem trackBarToolStripMenuItem;
    }
}