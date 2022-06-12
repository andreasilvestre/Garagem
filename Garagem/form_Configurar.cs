using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    public partial class form_Configurar : Form
    {
        public form_Configurar()
        {
            InitializeComponent();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {

            bool validado = true;
            if (textBox_TamanhoGaragem.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite a quantidade de vagas que a garagem possui.", "Alerta");
                validado = false;
                return;
            }
            if (textBox_ValorHora.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite o valor da hora.", "Alerta");
                validado = false;
                return;
            }
            if (validado)
            {
                Configurar configurar = new Configurar(int.Parse(textBox_TamanhoGaragem.Text), double.Parse(textBox_ValorHora.Text));
                configurar.gravarConfiguracao();
            }
        }
    }
}
