using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem
{
    public class Veiculo
    {

        //Para o Classe Veiculo:
        //atributos: placaVeiculo, dataEntrada, horaEntrada, tempoPermanencia, valorCobrado
        //métodos: construtor só com placaVeiculo, dataEntrada, horaEntrada; getters e setters

        string placa; 
        string dataEntrada;
        string horaEntrada;
        double valorHora; 
        string dataSaida;
        string horaSaida;
        int permanenciaMinuto;
        int permanenciaHora;
        double valorCobrado;

        public Veiculo()
        {
        }

        public Veiculo(string placa)
        {
            this.Placa = placa;
        }
        public Veiculo(string placa, string dataEntrada, string horaEntrada, double valorHora)
        {
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;
            this.ValorHora = valorHora;
        }

        public Veiculo(string placa, string dataSaida, string horaSaida, int permanenciaMinuto, int permanenciaHora, double valorHora, double valorCobrado)
        {
            this.placa = placa;
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.permanenciaMinuto = permanenciaMinuto;
            this.permanenciaHora = permanenciaHora;
            this.valorHora = valorHora;
            this.valorCobrado = valorCobrado;
        }

        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int PermanenciaMinuto { get => permanenciaMinuto; set => permanenciaMinuto = value; }
        public int PermanenciaHora { get => permanenciaHora; set => permanenciaHora = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

        public static bool jaCadastrado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return true;
                }
            }
            return false;
        }

        public static int Localiza(string placa, List<Veiculo> lista)
        {

            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27;
        }

        public static string retorna_DataHoraEntrada(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return i.DataEntrada + " " + i.HoraEntrada;
                }
            }
            return "";
        }

        public static double retorna_ValorHora(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return i.valorHora;
                }
            }
            return 0;
        }

    }
}
