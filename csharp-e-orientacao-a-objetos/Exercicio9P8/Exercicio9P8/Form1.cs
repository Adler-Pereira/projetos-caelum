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
        private Conta c;
        private TotalizadorDeContas totalContas = new TotalizadorDeContas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Conta();
            c.Titular = new Titular("Victor");
            c.Numero = 1;
            textoTitular.Text = c.Titular.Nome;
            textoSaldo.Text = Convert.ToString(c.Saldo);
            textoNumero.Text = Convert.ToString(c.Numero);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(textoValor.Text);
            c.Deposita(valorDeposito);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(textoValor.Text);
            c.Saca(valorDeposito);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void btTotalConta_Click(object sender, EventArgs e)
        {
            totalContas.Adiciona(c);
        }
    }
}
