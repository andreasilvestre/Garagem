using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    public partial class form_ComecarODia : Form
    {
        public form_ComecarODia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBoxButtons.YesNo()"Confirma procedimento");

            StreamWriter escritor2 = new StreamWriter("entrada.dat");
            escritor2.Close();

            StreamWriter escritor3 = new StreamWriter("saida.dat");
            escritor3.Close();

            MessageBox.Show("Arquivos zerados com sucesso.", "Informação:");
        }

        private void button_ZerarEntrada_Click(object sender, EventArgs e)
        {
            const string message = "Deseja zerar o arquivo de Entrada?";
            const string caption = "Zerando Entrada";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StreamWriter escritor = new StreamWriter("entrada.dat");
                escritor.Close();
                MessageBox.Show("Arquivo de entrada zerado com sucesso.");

            }
        }

        private void button_ZerarSaida_Click(object sender, EventArgs e)
        {
            const string message = "Deseja zerar o arquivo de Saída?";
            const string caption = "Zerando Saída";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StreamWriter escritor = new StreamWriter("saida.dat");
                escritor.Close();
                MessageBox.Show("Arquivo de saída zerado com sucesso.");

            }
        }
    }
}
