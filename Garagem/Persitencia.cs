using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    public class Persitencia
    {
        //Para a Classe de Persistencia:
        //métodos de classe: l
        //lerArquivoVeiculosEntrada(); lerArquivoVeiculosSaida();
        //gravarArquivoVeiculosEntrada(); gravarArquivoVeiculosSaida();
        public Persitencia()
        {

        }
        public static void lerEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("entrada.dat");
            string linha; //placa;dataEntrada,dataHora
            string[] vetorLinha;//DAE7484;11/02/2022;10:23 

            do
            {
                linha = leitor.ReadLine();

                //ERRO - Ele dá erro se o arquivo estiver vazio
                if (linha != null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2],double.Parse(vetorLinha[3])));
                }
                //if (!leitor.EndOfStream) 
                //{
                //    vetorLinha = linha.Split(';');
                //    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                //}
            } while (!leitor.EndOfStream);

            leitor.Close();
        }
        public static void lerSaida()
        { 
        
        }
        public static void gravarEntrada(List<Veiculo> lista)
        {

            StreamWriter escritor = new StreamWriter("entrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.ValorHora);
                escritor.Flush();
            }
            escritor.Close();

        }
        public static void gravarSaida()
        { 
        
        }

    }
}
