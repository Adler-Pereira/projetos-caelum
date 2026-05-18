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
        private Conta[] contas = new Conta[1];
        private Conta[] contasAux;
        private Conta selecionada;
        private int numeroDeContas = 0;
        private TotalizadorDeContas totalContas = new TotalizadorDeContas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            c1.Titular = new Titular("Victor");
            c1.Numero = 1;
            c1.Deposita(200.0);
            AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Titular("Mauricio");
            c2.Numero = 2;
            AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Titular("Osni");
            c3.Numero = 3;
            c3.Deposita(100.0);
            AdicionaConta(c3);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valorDeposito = Convert.ToDouble(textoValor.Text);
                selecionada.Deposita(valorDeposito);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento Inválido");
            }
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            try
            {
                double valorDeposito = Convert.ToDouble(textoValor.Text);
                selecionada.Saca(valorDeposito);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
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
            contasAux = new Conta[contas.Length];
            contasAux = contas;
            contas = new Conta[contasAux.Length+1];

            for (int i = 0; i < contasAux.Length; i++) contas[i] = contasAux[i];

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

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            foreach (Conta conta in contas)
            {
                if (conta is ContaCorrente)
                {
                    ContaCorrente contaCorrente = (ContaCorrente)conta;
                    double imposto = contaCorrente.CalculaTributos();
                    MessageBox.Show("Imposto da conta " + conta.Numero + ": " + imposto);


                    //PERGUNTAR AO FABIO SOBRE OS "AS" ABAIXO
                    //
                    //ContaCorrente contaCorrente = conta as ContaCorrente;
                    //double imposto = contaCorrente.CalculaTributos();
                    //MessageBox.Show("Imposto da conta " + conta.Numero + ": " + imposto);
                    //
                    //ITributavel iTributavel = conta as ITributavel;
                    //double imposto = iTributavel.CalculaTributos();
                    //MessageBox.Show("Imposto da conta " + conta.Numero + ": " + imposto);
                }
            }
        }
    }
}
