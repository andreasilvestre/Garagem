namespace Garagem
{
    partial class form_Configurar
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
            this.label_TamanhoGaragem = new System.Windows.Forms.Label();
            this.label_ValorHora = new System.Windows.Forms.Label();
            this.textBox_TamanhoGaragem = new System.Windows.Forms.TextBox();
            this.textBox_ValorHora = new System.Windows.Forms.TextBox();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TamanhoGaragem
            // 
            this.label_TamanhoGaragem.AutoSize = true;
            this.label_TamanhoGaragem.Location = new System.Drawing.Point(12, 9);
            this.label_TamanhoGaragem.Name = "label_TamanhoGaragem";
            this.label_TamanhoGaragem.Size = new System.Drawing.Size(173, 13);
            this.label_TamanhoGaragem.TabIndex = 0;
            this.label_TamanhoGaragem.Text = "Quantidade de vagas na Garagem:";
            // 
            // label_ValorHora
            // 
            this.label_ValorHora.AutoSize = true;
            this.label_ValorHora.Location = new System.Drawing.Point(125, 40);
            this.label_ValorHora.Name = "label_ValorHora";
            this.label_ValorHora.Size = new System.Drawing.Size(60, 13);
            this.label_ValorHora.TabIndex = 1;
            this.label_ValorHora.Text = "Valor Hora:";
            // 
            // textBox_TamanhoGaragem
            // 
            this.textBox_TamanhoGaragem.Location = new System.Drawing.Point(191, 9);
            this.textBox_TamanhoGaragem.Name = "textBox_TamanhoGaragem";
            this.textBox_TamanhoGaragem.Size = new System.Drawing.Size(65, 20);
            this.textBox_TamanhoGaragem.TabIndex = 0;
            // 
            // textBox_ValorHora
            // 
            this.textBox_ValorHora.Location = new System.Drawing.Point(191, 40);
            this.textBox_ValorHora.Name = "textBox_ValorHora";
            this.textBox_ValorHora.Size = new System.Drawing.Size(65, 20);
            this.textBox_ValorHora.TabIndex = 1;
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(173, 85);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(83, 35);
            this.button_Salvar.TabIndex = 2;
            this.button_Salvar.Text = "&Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // form_Configurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 136);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.textBox_ValorHora);
            this.Controls.Add(this.textBox_TamanhoGaragem);
            this.Controls.Add(this.label_ValorHora);
            this.Controls.Add(this.label_TamanhoGaragem);
            this.Name = "form_Configurar";
            this.Text = "Configurar Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TamanhoGaragem;
        private System.Windows.Forms.Label label_ValorHora;
        private System.Windows.Forms.TextBox textBox_TamanhoGaragem;
        private System.Windows.Forms.TextBox textBox_ValorHora;
        private System.Windows.Forms.Button button_Salvar;
    }
}