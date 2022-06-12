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
            this.button_ZerarArquivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ZerarArquivos
            // 
            this.button_ZerarArquivos.Location = new System.Drawing.Point(65, 71);
            this.button_ZerarArquivos.Name = "button_ZerarArquivos";
            this.button_ZerarArquivos.Size = new System.Drawing.Size(217, 116);
            this.button_ZerarArquivos.TabIndex = 0;
            this.button_ZerarArquivos.Text = "&Zerar Arquivos\r\n\r\nEsta operação irá zerar seus arquivos de Entrada e Saída.\r\n\r\nT" +
    "em certeza que deseja começar o dia?";
            this.button_ZerarArquivos.UseVisualStyleBackColor = true;
            this.button_ZerarArquivos.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_ComecarODia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 292);
            this.Controls.Add(this.button_ZerarArquivos);
            this.Name = "form_ComecarODia";
            this.Text = "Comecar o Dia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ZerarArquivos;
    }
}