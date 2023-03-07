namespace componets
{
    partial class CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_bicicleta = new System.Windows.Forms.CheckBox();
            this.btn_marcadosCheckbox = new System.Windows.Forms.Button();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(42, 68);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(53, 19);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(42, 93);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(54, 19);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "aviao";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_bicicleta
            // 
            this.cb_bicicleta.AutoSize = true;
            this.cb_bicicleta.Location = new System.Drawing.Point(42, 118);
            this.cb_bicicleta.Name = "cb_bicicleta";
            this.cb_bicicleta.Size = new System.Drawing.Size(70, 19);
            this.cb_bicicleta.TabIndex = 2;
            this.cb_bicicleta.Text = "bicicleta";
            this.cb_bicicleta.UseVisualStyleBackColor = true;
            // 
            // btn_marcadosCheckbox
            // 
            this.btn_marcadosCheckbox.Location = new System.Drawing.Point(136, 64);
            this.btn_marcadosCheckbox.Name = "btn_marcadosCheckbox";
            this.btn_marcadosCheckbox.Size = new System.Drawing.Size(189, 23);
            this.btn_marcadosCheckbox.TabIndex = 3;
            this.btn_marcadosCheckbox.Text = "Marcados no CHeckBox";
            this.btn_marcadosCheckbox.UseVisualStyleBackColor = true;
            this.btn_marcadosCheckbox.Click += new System.EventHandler(this.btn_marcadosCheckbox_Click);
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(42, 143);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(62, 19);
            this.cb_onibus.TabIndex = 4;
            this.cb_onibus.Text = "onibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 348);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.btn_marcadosCheckbox);
            this.Controls.Add(this.cb_bicicleta);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_marcadosCheckbox;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_bicicleta;
        public System.Windows.Forms.CheckBox cb_onibus;
    }
}