namespace Garagem
{
    partial class form_Cadastro
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
            this.label_Placa = new System.Windows.Forms.Label();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.label_Data = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.textBox_Hora = new System.Windows.Forms.TextBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.button_Entrar = new System.Windows.Forms.Button();
            this.textBox_NaGaragem = new System.Windows.Forms.TextBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.label_Lista = new System.Windows.Forms.Label();
            this.label_Vagas = new System.Windows.Forms.Label();
            this.textBox_Vagas = new System.Windows.Forms.TextBox();
            this.textBox_ValorHora = new System.Windows.Forms.TextBox();
            this.label_ValorHora = new System.Windows.Forms.Label();
            this.textBox_ResumoSaida = new System.Windows.Forms.TextBox();
            this.label_ResumoSaida = new System.Windows.Forms.Label();
            this.button_ConfirmarSaida = new System.Windows.Forms.Button();
            this.label_ListaaPopular = new System.Windows.Forms.Label();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.label_Disponivel = new System.Windows.Forms.Label();
            this.textBox_Disponivel = new System.Windows.Forms.TextBox();
            this.textBox_Sairam = new System.Windows.Forms.TextBox();
            this.label_Sairam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Location = new System.Drawing.Point(8, 45);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(37, 13);
            this.label_Placa.TabIndex = 0;
            this.label_Placa.Text = "Placa:";
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Placa.Location = new System.Drawing.Point(51, 45);
            this.textBox_Placa.MaxLength = 7;
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(92, 20);
            this.textBox_Placa.TabIndex = 0;
            this.textBox_Placa.TextChanged += new System.EventHandler(this.textBox_Placa_TextChanged);
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(12, 9);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(33, 13);
            this.label_Data.TabIndex = 4;
            this.label_Data.Text = "Data:";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Enabled = false;
            this.textBox_Data.Location = new System.Drawing.Point(51, 9);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(92, 20);
            this.textBox_Data.TabIndex = 5;
            this.textBox_Data.TextChanged += new System.EventHandler(this.textBox_Data_TextChanged);
            // 
            // textBox_Hora
            // 
            this.textBox_Hora.Enabled = false;
            this.textBox_Hora.Location = new System.Drawing.Point(188, 9);
            this.textBox_Hora.Name = "textBox_Hora";
            this.textBox_Hora.Size = new System.Drawing.Size(51, 20);
            this.textBox_Hora.TabIndex = 6;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(149, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 13);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = "Hora:";
            // 
            // button_Entrar
            // 
            this.button_Entrar.Location = new System.Drawing.Point(11, 89);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(106, 43);
            this.button_Entrar.TabIndex = 8;
            this.button_Entrar.Text = "&Entrar";
            this.button_Entrar.UseVisualStyleBackColor = true;
            this.button_Entrar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // textBox_NaGaragem
            // 
            this.textBox_NaGaragem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_NaGaragem.Location = new System.Drawing.Point(289, 89);
            this.textBox_NaGaragem.Multiline = true;
            this.textBox_NaGaragem.Name = "textBox_NaGaragem";
            this.textBox_NaGaragem.Size = new System.Drawing.Size(234, 255);
            this.textBox_NaGaragem.TabIndex = 9;
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(130, 89);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(109, 43);
            this.button_Sair.TabIndex = 10;
            this.button_Sair.Text = "&Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // label_Lista
            // 
            this.label_Lista.AutoSize = true;
            this.label_Lista.Location = new System.Drawing.Point(397, 21);
            this.label_Lista.Name = "label_Lista";
            this.label_Lista.Size = new System.Drawing.Size(0, 13);
            this.label_Lista.TabIndex = 11;
            // 
            // label_Vagas
            // 
            this.label_Vagas.AutoSize = true;
            this.label_Vagas.Location = new System.Drawing.Point(354, 12);
            this.label_Vagas.Name = "label_Vagas";
            this.label_Vagas.Size = new System.Drawing.Size(40, 13);
            this.label_Vagas.TabIndex = 14;
            this.label_Vagas.Text = "Vagas:";
            // 
            // textBox_Vagas
            // 
            this.textBox_Vagas.Enabled = false;
            this.textBox_Vagas.Location = new System.Drawing.Point(400, 9);
            this.textBox_Vagas.Name = "textBox_Vagas";
            this.textBox_Vagas.Size = new System.Drawing.Size(71, 20);
            this.textBox_Vagas.TabIndex = 15;
            // 
            // textBox_ValorHora
            // 
            this.textBox_ValorHora.Enabled = false;
            this.textBox_ValorHora.Location = new System.Drawing.Point(578, 16);
            this.textBox_ValorHora.Name = "textBox_ValorHora";
            this.textBox_ValorHora.Size = new System.Drawing.Size(71, 20);
            this.textBox_ValorHora.TabIndex = 16;
            // 
            // label_ValorHora
            // 
            this.label_ValorHora.AutoSize = true;
            this.label_ValorHora.Location = new System.Drawing.Point(512, 19);
            this.label_ValorHora.Name = "label_ValorHora";
            this.label_ValorHora.Size = new System.Drawing.Size(60, 13);
            this.label_ValorHora.TabIndex = 17;
            this.label_ValorHora.Text = "Valor Hora:";
            // 
            // textBox_ResumoSaida
            // 
            this.textBox_ResumoSaida.Enabled = false;
            this.textBox_ResumoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ResumoSaida.Location = new System.Drawing.Point(11, 169);
            this.textBox_ResumoSaida.Multiline = true;
            this.textBox_ResumoSaida.Name = "textBox_ResumoSaida";
            this.textBox_ResumoSaida.Size = new System.Drawing.Size(228, 120);
            this.textBox_ResumoSaida.TabIndex = 18;
            // 
            // label_ResumoSaida
            // 
            this.label_ResumoSaida.AutoSize = true;
            this.label_ResumoSaida.Location = new System.Drawing.Point(9, 150);
            this.label_ResumoSaida.Name = "label_ResumoSaida";
            this.label_ResumoSaida.Size = new System.Drawing.Size(96, 13);
            this.label_ResumoSaida.TabIndex = 19;
            this.label_ResumoSaida.Text = "Resumo da Saída:";
            // 
            // button_ConfirmarSaida
            // 
            this.button_ConfirmarSaida.Location = new System.Drawing.Point(130, 301);
            this.button_ConfirmarSaida.Name = "button_ConfirmarSaida";
            this.button_ConfirmarSaida.Size = new System.Drawing.Size(109, 43);
            this.button_ConfirmarSaida.TabIndex = 20;
            this.button_ConfirmarSaida.Text = "&Confirmar\r\nSaída";
            this.button_ConfirmarSaida.UseVisualStyleBackColor = true;
            this.button_ConfirmarSaida.Click += new System.EventHandler(this.button_ConfirmarSaida_Click);
            // 
            // label_ListaaPopular
            // 
            this.label_ListaaPopular.AutoSize = true;
            this.label_ListaaPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListaaPopular.Location = new System.Drawing.Point(286, 68);
            this.label_ListaaPopular.Name = "label_ListaaPopular";
            this.label_ListaaPopular.Size = new System.Drawing.Size(68, 13);
            this.label_ListaaPopular.TabIndex = 21;
            this.label_ListaaPopular.Text = "Na garagem:";
            this.label_ListaaPopular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(156, 35);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(83, 43);
            this.button_Limpar.TabIndex = 22;
            this.button_Limpar.Text = "&Atualizar e\r\nLimpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // label_Disponivel
            // 
            this.label_Disponivel.AutoSize = true;
            this.label_Disponivel.Location = new System.Drawing.Point(333, 34);
            this.label_Disponivel.Name = "label_Disponivel";
            this.label_Disponivel.Size = new System.Drawing.Size(61, 13);
            this.label_Disponivel.TabIndex = 24;
            this.label_Disponivel.Text = "Disponível:";
            // 
            // textBox_Disponivel
            // 
            this.textBox_Disponivel.Location = new System.Drawing.Point(400, 35);
            this.textBox_Disponivel.Name = "textBox_Disponivel";
            this.textBox_Disponivel.Size = new System.Drawing.Size(71, 20);
            this.textBox_Disponivel.TabIndex = 25;
            // 
            // textBox_Sairam
            // 
            this.textBox_Sairam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Sairam.Location = new System.Drawing.Point(533, 89);
            this.textBox_Sairam.Multiline = true;
            this.textBox_Sairam.Name = "textBox_Sairam";
            this.textBox_Sairam.Size = new System.Drawing.Size(239, 255);
            this.textBox_Sairam.TabIndex = 26;
            // 
            // label_Sairam
            // 
            this.label_Sairam.AutoSize = true;
            this.label_Sairam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sairam.Location = new System.Drawing.Point(530, 68);
            this.label_Sairam.Name = "label_Sairam";
            this.label_Sairam.Size = new System.Drawing.Size(44, 13);
            this.label_Sairam.TabIndex = 27;
            this.label_Sairam.Text = "Saíram:";
            this.label_Sairam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 383);
            this.Controls.Add(this.label_Sairam);
            this.Controls.Add(this.textBox_Sairam);
            this.Controls.Add(this.textBox_Disponivel);
            this.Controls.Add(this.label_Disponivel);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.label_ListaaPopular);
            this.Controls.Add(this.button_ConfirmarSaida);
            this.Controls.Add(this.label_ResumoSaida);
            this.Controls.Add(this.textBox_ResumoSaida);
            this.Controls.Add(this.label_ValorHora);
            this.Controls.Add(this.textBox_ValorHora);
            this.Controls.Add(this.textBox_Vagas);
            this.Controls.Add(this.label_Vagas);
            this.Controls.Add(this.label_Lista);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.textBox_NaGaragem);
            this.Controls.Add(this.button_Entrar);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.textBox_Hora);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.label_Placa);
            this.Name = "form_Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.form_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.TextBox textBox_Placa;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.TextBox textBox_Hora;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button button_Entrar;
        private System.Windows.Forms.TextBox textBox_NaGaragem;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Label label_Lista;
        private System.Windows.Forms.Label label_Vagas;
        private System.Windows.Forms.TextBox textBox_Vagas;
        private System.Windows.Forms.TextBox textBox_ValorHora;
        private System.Windows.Forms.Label label_ValorHora;
        private System.Windows.Forms.TextBox textBox_ResumoSaida;
        private System.Windows.Forms.Label label_ResumoSaida;
        private System.Windows.Forms.Button button_ConfirmarSaida;
        private System.Windows.Forms.Label label_ListaaPopular;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Label label_Disponivel;
        private System.Windows.Forms.TextBox textBox_Disponivel;
        private System.Windows.Forms.TextBox textBox_Sairam;
        private System.Windows.Forms.Label label_Sairam;
    }
}