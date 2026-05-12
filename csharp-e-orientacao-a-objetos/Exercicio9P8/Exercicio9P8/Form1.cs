using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9P8
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private Conta selecionada;
        private TotalizadorDeContas totalContas = new TotalizadorDeContas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Titular("Victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Titular("Mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Titular("Osni");
            this.contas[2].Numero = 3;
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valorDeposito);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valorDeposito);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void btTotalConta_Click(object sender, EventArgs e)
        {
            totalContas.Adiciona(selecionada);
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }
    }
}
