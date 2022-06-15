namespace Garagem
{
    partial class form_ComecarODia
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
            this.button_ZerarEntrada = new System.Windows.Forms.Button();
            this.button_ZerarSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ZerarEntrada
            // 
            this.button_ZerarEntrada.Location = new System.Drawing.Point(65, 76);
            this.button_ZerarEntrada.Name = "button_ZerarEntrada";
            this.button_ZerarEntrada.Size = new System.Drawing.Size(140, 38);
            this.button_ZerarEntrada.TabIndex = 1;
            this.button_ZerarEntrada.Text = "Zerar Entrada";
            this.button_ZerarEntrada.UseVisualStyleBackColor = true;
            this.button_ZerarEntrada.Click += new System.EventHandler(this.button_ZerarEntrada_Click);
            // 
            // button_ZerarSaida
            // 
            this.button_ZerarSaida.Location = new System.Drawing.Point(65, 134);
            this.button_ZerarSaida.Name = "button_ZerarSaida";
            this.button_ZerarSaida.Size = new System.Drawing.Size(140, 39);
            this.button_ZerarSaida.TabIndex = 2;
            this.button_ZerarSaida.Text = "Zerar Saída";
            this.button_ZerarSaida.UseVisualStyleBackColor = true;
            this.button_ZerarSaida.Click += new System.EventHandler(this.button_ZerarSaida_Click);
            // 
            // form_ComecarODia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.button_ZerarSaida);
            this.Controls.Add(this.button_ZerarEntrada);
            this.Name = "form_ComecarODia";
            this.Text = "Começar o Dia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_ZerarEntrada;
        private System.Windows.Forms.Button button_ZerarSaida;
    }
}