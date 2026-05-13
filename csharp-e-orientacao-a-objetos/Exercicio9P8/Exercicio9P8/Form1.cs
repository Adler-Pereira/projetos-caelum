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
        private int numeroDeContas = 0;
        private TotalizadorDeContas totalContas = new TotalizadorDeContas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];
            Conta c1 = new Conta();
            c1.Titular = new Titular("Victor");
            c1.Numero = 1;
            AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Titular("Mauricio");
            c2.Numero = 2;
            AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Titular("Osni");
            c3.Numero = 3;
            AdicionaConta(c3);
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

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void btTransferencia_Click(object sender, EventArgs e)
        {
            int indiceDestino = comboDestinoTransferencia.SelectedIndex;
            double valorTrans = Convert.ToDouble(numCompValor.Value);
            Conta destino = contas[indiceDestino];

            selecionada.Saca(valorTrans);
            destino.Deposita(valorTrans);

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
        }

        private void btNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formDeCadastro = new FormCadastroConta(this);
            formDeCadastro.ShowDialog();
        }
    }
}
