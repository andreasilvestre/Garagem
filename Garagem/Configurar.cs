using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    internal class Configurar
    {
        int tamanhoGaragem;
        double valorHora;

        public Configurar()
        {

        }
        public Configurar(int tamanhoGaragem, double valorHora)
        {
            this.TamanhoGaragem = tamanhoGaragem;
            this.ValorHora = valorHora;
        }

        public void gravarConfiguracao()
        {
            
            StreamWriter escritor = new StreamWriter("configuracao.dat");
            escritor.WriteLine(tamanhoGaragem + ";" + valorHora);
            escritor.Flush();
            escritor.Close();
            
            //StreamWriter escritor2 = new StreamWriter("entrada.dat");
            //escritor2.Close();

            //StreamWriter escritor3 = new StreamWriter("saida.dat");
            //escritor3.Close();

            MessageBox.Show("Configuracao gravada com sucesso.", "Informativo:");
        }

        public void lerConfiguracao()
        {
            string linha; //lê apenas a primeira linha pois só existe uma única linha
            StreamReader leitor = new StreamReader("configuracao.dat");
            linha = leitor.ReadLine();
            string[] vetorLinha = linha.Split(';');
            this.TamanhoGaragem = int.Parse(vetorLinha[0]);
            this.ValorHora = double.Parse(vetorLinha[1]);
            leitor.Close();
        }
        public int TamanhoGaragem { get => tamanhoGaragem; set => tamanhoGaragem = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
    }

}
