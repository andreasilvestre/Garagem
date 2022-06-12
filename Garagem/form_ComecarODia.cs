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
    }
}
