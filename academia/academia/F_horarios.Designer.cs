namespace academia
{
    partial class F_horarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_idHorario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.btn_salvarHorario = new System.Windows.Forms.Button();
            this.btn_excluirHorario = new System.Windows.Forms.Button();
            this.btn_fecharHorario = new System.Windows.Forms.Button();
            this.mst_horario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 35);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(65, 23);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            // 
            // lb_idHorario
            // 
            this.lb_idHorario.AutoSize = true;
            this.lb_idHorario.Location = new System.Drawing.Point(12, 17);
            this.lb_idHorario.Name = "lb_idHorario";
            this.lb_idHorario.Size = new System.Drawing.Size(18, 15);
            this.lb_idHorario.TabIndex = 1;
            this.lb_idHorario.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário";
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(12, 75);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowTemplate.Height = 25;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(485, 282);
            this.dgv_horarios.TabIndex = 3;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoHorario.Location = new System.Drawing.Point(3, 3);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(100, 23);
            this.btn_novoHorario.TabIndex = 4;
            this.btn_novoHorario.Text = "Novo Horario";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // btn_salvarHorario
            // 
            this.btn_salvarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarHorario.Location = new System.Drawing.Point(126, 3);
            this.btn_salvarHorario.Name = "btn_salvarHorario";
            this.btn_salvarHorario.Size = new System.Drawing.Size(104, 23);
            this.btn_salvarHorario.TabIndex = 5;
            this.btn_salvarHorario.Text = "Salvar Horario";
            this.btn_salvarHorario.UseVisualStyleBackColor = true;
            this.btn_salvarHorario.Click += new System.EventHandler(this.btn_salvarHorario_Click);
            // 
            // btn_excluirHorario
            // 
            this.btn_excluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirHorario.Location = new System.Drawing.Point(249, 3);
            this.btn_excluirHorario.Name = "btn_excluirHorario";
            this.btn_excluirHorario.Size = new System.Drawing.Size(104, 23);
            this.btn_excluirHorario.TabIndex = 6;
            this.btn_excluirHorario.Text = "Excluir Horario";
            this.btn_excluirHorario.UseVisualStyleBackColor = true;
            this.btn_excluirHorario.Click += new System.EventHandler(this.btn_excluirHorario_Click);
            // 
            // btn_fecharHorario
            // 
            this.btn_fecharHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharHorario.Location = new System.Drawing.Point(390, 3);
            this.btn_fecharHorario.Name = "btn_fecharHorario";
            this.btn_fecharHorario.Size = new System.Drawing.Size(75, 23);
            this.btn_fecharHorario.TabIndex = 7;
            this.btn_fecharHorario.Text = "Fechar";
            this.btn_fecharHorario.UseVisualStyleBackColor = true;
            this.btn_fecharHorario.Click += new System.EventHandler(this.btn_fecharHorario_Click);
            // 
            // mst_horario
            // 
            this.mst_horario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mst_horario.Location = new System.Drawing.Point(83, 35);
            this.mst_horario.Mask = "99:99 \\as 99:99";
            this.mst_horario.Name = "mst_horario";
            this.mst_horario.Size = new System.Drawing.Size(96, 23);
            this.mst_horario.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fecharHorario);
            this.panel1.Controls.Add(this.btn_excluirHorario);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Controls.Add(this.btn_salvarHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 29);
            this.panel1.TabIndex = 9;
            // 
            // F_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mst_horario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_idHorario);
            this.Controls.Add(this.tb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao de Horarios";
            this.Load += new System.EventHandler(this.F_horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_id;
        private Label lb_idHorario;
        private Label label2;
        private DataGridView dgv_horarios;
        private Button btn_novoHorario;
        private Button btn_salvarHorario;
        private Button btn_excluirHorario;
        private Button btn_fecharHorario;
        private MaskedTextBox mst_horario;
        private Panel panel1;
    }
}