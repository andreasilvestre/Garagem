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
        int posicao;

        string placaSaida;
        string dataSaida;
        string horaSaida;
        int permanenciaMinuto;
        int permanenciaHora;
        double valorHora;
        double valorCobrado;

        private void popularNaGaragem(List<Veiculo> lista)
        {
            //textBox_NaGaragem.Text = "";
            listBox_NaGaragem.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                //textBox_NaGaragem.AppendText(contador + " - " + i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.ValorHora.ToString("C") + Environment.NewLine);
                listBox_NaGaragem.Items.Add(contador + " - " + i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.ValorHora.ToString("C"));
            }
        }

        private void popularSairam(List<Veiculo> lista)
        {
            //textBox_Sairam.Text = "";
            listBox_Sairam.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                //textBox_Sairam.AppendText(contador + " - " + i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C") + Environment.NewLine);
                listBox_Sairam.Items.Add(contador + " - " + i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C"));
            }
        }

        public form_Cadastro()
        {
            InitializeComponent();

            Persistencia.lerEntrada(listaNaGaragem); //lista vazia para popular
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerSaida(listaSairam);
            popularSairam(listaSairam);

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
            Persistencia.gravarEntrada(listaNaGaragem);
            //textBox_NaGaragem.AppendText(listaNaGaragem.Count + " - " + textBox_Placa.Text + " - " + dataEntrada + " - " + horaEntrada + " - " + configuracao.ValorHora.ToString("C") + Environment.NewLine);
            popularNaGaragem(listaNaGaragem);
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();
            
            
            
        }

        private void textBox_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Placa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Sair_Click(object sender, EventArgs e)
        {

            //FAZ RESUMO SAÍDA - NÃO SALVA POR ENQUANTO - APENAS EXIBE RESUMO
            //PARA GRAVAR SÁIDA APERTAR BOTÃO CONFIRMAR

            //validar campos preenchidos
            if (textBox_Placa.Text.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números.", "Preenchimento:");
                return;
            }

            //Verifica se o veículo está na garagem através da placa
            posicao = Veiculo.Localiza(textBox_Placa.Text, listaNaGaragem);
            if (posicao == -27)
            {
                MessageBox.Show("Veiculo não está na Garagem.\nPlaca não encontrada.", "Erro de digitação");
                return;
            }

            placaSaida = textBox_Placa.Text;

            DateTime dataHoraEntrada = DateTime.Parse(Veiculo.retorna_DataHoraEntrada(placaSaida, listaNaGaragem));
            DateTime dataHoraSaida = DateTime.Now;
            dataSaida = dataHoraSaida.ToShortDateString();
            horaSaida = dataHoraSaida.ToShortTimeString();

            TimeSpan intervalo;
            intervalo = dataHoraSaida - dataHoraEntrada;
            permanenciaMinuto = (int)Math.Round(intervalo.TotalMinutes);
            permanenciaHora = (int)Math.Ceiling(intervalo.TotalHours);

            valorHora = Veiculo.retorna_ValorHora(textBox_Placa.Text, listaNaGaragem);
            valorCobrado = (double)(Math.Ceiling(intervalo.TotalHours)) * valorHora;

            textBox_ResumoSaida.Text = "";
            textBox_ResumoSaida.AppendText("Entrou às: " + dataHoraEntrada.ToString() + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Saiu às: " + dataHoraSaida + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Round(intervalo.TotalMinutes)) + " minutos" + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + " horas" + Environment.NewLine);           
            textBox_ResumoSaida.AppendText("A receber: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours))  + " x " + valorHora.ToString("C") + " = " + valorCobrado.ToString("C") + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("intervalo total: " + intervalo.ToString() + Environment.NewLine);

            button_ConfirmarSaida.Enabled = true;

            

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

            // atualizando a entrada
            //apaga na entrada o veículo que saiu
            listaNaGaragem.RemoveAt(posicao);

            //exibir na tela a lista entrada atualizada
            popularNaGaragem(listaNaGaragem);

            //atualiza arquivo saida - refresh
            Persistencia.gravarEntrada(listaNaGaragem);

            //atualizando a saída
            //adiciona na lista de saída
            listaSairam.Add(new Veiculo(placaSaida, dataSaida, horaSaida, permanenciaMinuto, permanenciaHora, valorHora, valorCobrado));

            //popula textbox Saída - exibir na tela as saídas
            popularSairam(listaSairam);

            //grava no arquivo todas as saídas
            Persistencia.gravarSaida(listaSairam);

            //atualiza vagas disponíveis
            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();

            //desabilita o botão ConfimarSaida - somente o botão Sair o habilita
            button_ConfirmarSaida.Enabled = false;  
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
