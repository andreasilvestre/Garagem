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
    public partial class form_TelaPrincipal : Form
    {
        public form_TelaPrincipal()
        {
            InitializeComponent();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Cadastro cadastro = new form_Cadastro();
            cadastro.ShowDialog();  
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Configurar configurar = new form_Configurar();
            configurar.ShowDialog();
        }

        private void começarODiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ComecarODia comecar = new form_ComecarODia();
            comecar.ShowDialog();   
        }

        private void naGaragemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saíramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
