namespace componets
{
    partial class DateTimePicker
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
            this.btn_obterData = new System.Windows.Forms.Button();
            this.btn_alterarData = new System.Windows.Forms.Button();
            this.tb_obterData = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(292, 26);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(99, 23);
            this.btn_obterData.TabIndex = 0;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // btn_alterarData
            // 
            this.btn_alterarData.Location = new System.Drawing.Point(292, 128);
            this.btn_alterarData.Name = "btn_alterarData";
            this.btn_alterarData.Size = new System.Drawing.Size(99, 23);
            this.btn_alterarData.TabIndex = 2;
            this.btn_alterarData.Text = "Alterar Data";
            this.btn_alterarData.UseVisualStyleBackColor = true;
            this.btn_alterarData.Click += new System.EventHandler(this.btn_alterarData_Click);
            // 
            // tb_obterData
            // 
            this.tb_obterData.Location = new System.Drawing.Point(14, 74);
            this.tb_obterData.Name = "tb_obterData";
            this.tb_obterData.Size = new System.Drawing.Size(254, 23);
            this.tb_obterData.TabIndex = 3;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 129);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(66, 23);
            this.tb_dia.TabIndex = 4;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(84, 129);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(78, 23);
            this.tb_mes.TabIndex = 5;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(168, 129);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 23);
            this.tb_ano.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 319);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_obterData);
            this.Controls.Add(this.btn_alterarData);
            this.Controls.Add(this.btn_obterData);
            this.Name = "DateTimePicker";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_obterData;
        private Button btn_alterarData;
        private TextBox tb_obterData;
        private TextBox tb_dia;
        private TextBox tb_mes;
        private TextBox tb_ano;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}