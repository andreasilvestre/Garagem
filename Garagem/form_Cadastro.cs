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
    public partial class form_Cadastro : Form
    {
        List<Veiculo> listaNaGaragem = new List<Veiculo> ();
        List<Veiculo> listaSairam = new List<Veiculo> ();
        //string[] linhaConfiguracao;
        
        private void popularVeiculosNaGaragem(List<Veiculo> lista)
        {
            textBox_NaGaragem.Text = "";
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                textBox_NaGaragem.AppendText(contador + " - " + i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + Environment.NewLine);
            }
        }


        public form_Cadastro()
        {
            InitializeComponent();
            Persitencia.lerEntrada(listaNaGaragem); //lista vazia para popular
            popularVeiculosNaGaragem(listaNaGaragem);

            DateTime dataNow = DateTime.Now;

            textBox_Data.Text = dataNow.ToShortDateString();
            textBox_Hora.Text = dataNow.ToShortTimeString();

            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

            textBox_Vagas.Text = configuracao.TamanhoGaragem.ToString();
            textBox_ValorHora.Text = configuracao.ValorHora.ToString("C");
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem  - listaNaGaragem.Count).ToString();
        }

        private void form_Cadastro_Load(object sender, EventArgs e)
        {
            

        }

        //botão entrar - não alterou o nome do botão no código
        private void button_Salvar_Click(object sender, EventArgs e)
        {

            //validar campos preenchidos
            if (textBox_Placa.Text.Length != 7 )           
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números", "Preenchimento:");
                return;
            }

            //Já está cadastrado - não pode repetir
            if (Veiculo.jaCadastrado(textBox_Placa.Text, listaNaGaragem))
            {
                MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Erro de digitação");
                return;
            }

            //existe vaga?
            //verificar na lista quantos veiculos estão na garagem
            //tammanho máximo na configuração = configura
            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

            if (listaNaGaragem.Count >= configuracao.TamanhoGaragem)
            {
                MessageBox.Show("A garagem está cheia. \nNão há vagas disponíveis", "Lotação");
                return;
            }

            DateTime dataAgora = DateTime.Now;
            string dataEntrada = dataAgora.ToShortDateString();
            string horaEntrada = dataAgora.ToShortTimeString();

            listaNaGaragem.Add(new Veiculo(textBox_Placa.Text, dataEntrada, horaEntrada,configuracao.ValorHora));
            Persitencia.gravarEntrada(listaNaGaragem);
            textBox_NaGaragem.AppendText(listaNaGaragem.Count + " - " + textBox_Placa.Text + " - " + dataEntrada + " - " + horaEntrada + " - " + configuracao.ValorHora.ToString("C") + Environment.NewLine);
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();
            
            
            //TESTES
            //TimeSpan intervalo;
            //DateTime dataCriacao;
            //dataCriacao = DateTime.Parse("11/06/2022 13:20");
            //intervalo = DateTime.Now - dataCriacao;
            ////textBox_Teste.Text = Convert.ToString(intervalo, Environment);
            //textBox_Teste.AppendText("Intervalo: " + Convert.ToString(intervalo) + Environment.NewLine);
            //textBox_Teste.AppendText("Em minutos: " + Convert.ToString(intervalo.TotalMinutes) + Environment.NewLine);
            //textBox_Teste.AppendText("Em horas arrendondada para cima: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + Environment.NewLine);
            //textBox_Teste.AppendText("Dias: " + Convert.ToString(intervalo.TotalDays) + Environment.NewLine);
            
        }

        private void textBox_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Placa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Sair_Click(object sender, EventArgs e)
        {

            //GRAVANDO SAÍDA DE VEICULOS

            //validar campos preenchidos
            if (textBox_Placa.Text.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números", "Preenchimento:");
                return;
            }

            //Verifica se o veículo está na garagem através da placa
            int posicao = Veiculo.Localiza(textBox_Placa.Text, listaNaGaragem);
            if (posicao == -27)
            {
                MessageBox.Show("Veiculo não está na Garagem.\nPlaca não encontrada.", "Erro de digitação");
                return;
            }
            else
            {
            }

            DateTime dataHoraEntrada = DateTime.Parse(Veiculo.retorna_DataHoraEntrada(textBox_Placa.Text, listaNaGaragem));
            DateTime dataHoraSaida = DateTime.Now;

            TimeSpan intervalo;
            intervalo = dataHoraSaida - dataHoraEntrada;

            textBox_ResumoSaida.Text = "";
            double ValorHora = Veiculo.retorna_ValorHora(textBox_Placa.Text, listaNaGaragem);
            double valorCobrado = (double)(Math.Ceiling(intervalo.TotalHours)) * ValorHora;
           
            textBox_ResumoSaida.AppendText("Entrou às: " + dataHoraEntrada.ToString() + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Saiu às: " + dataHoraSaida + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo em minutos: " + Convert.ToString(Math.Round(intervalo.TotalMinutes)) + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo em horas: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + Environment.NewLine);           
            textBox_ResumoSaida.AppendText("A receber: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours))  + " x " + ValorHora.ToString("C") + " = " + valorCobrado.ToString("C") + Environment.NewLine);


            //apagar a pessoa da lista
            //listaNaGaragem.RemoveAt(posicao);

            //Placa, DataSaida, HoraSaida, PermanenciaMinuto, PermanenciaHora, ValorHora, ValorCobrado)
            //listaSairam.Add(new Veiculo(textBox_Placa.Text, dataSaida, horaSaida, PermanenciaMinuto, PermanenciaHora, ValorHora, ValorCobrado));

            //Persitencia.gravarSaida(listaNaGaragem);
            //textBox_NaGaragem.AppendText(listaNaGaragem.Count + " - " + textBox_Placa.Text + " - " + dataEntrada + " - " + horaEntrada + Environment.NewLine);
            //textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();






            //TESTES
            //textBox_ResumoSaida.Text = "";
            //textBox_Teste.AppendText("Intervalo: " + Convert.ToString(intervalo) + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Entrou às: " + "11/06/2022" + " " + "10:05" + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Saiu às: " + "11/06/2022" + " " + "13:22" + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Permanência: " + "123" + " minutos => " + "3" + "horas" + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("A receber: " + "3 X 5 = R$15,00" + Environment.NewLine);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_Teste_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button_ConfirmarSaida_Click(object sender, EventArgs e)
        {

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            DateTime dataNow = DateTime.Now;

            textBox_Data.Text = dataNow.ToShortDateString();
            textBox_Hora.Text = dataNow.ToShortTimeString();
            textBox_Placa.Text = "";
            textBox_ResumoSaida.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }

}
