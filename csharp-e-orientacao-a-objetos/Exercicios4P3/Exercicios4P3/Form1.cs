using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios4P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaque1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            MessageBox.Show("saldo " + saldo);
        }

        private void btnSaque2_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            MessageBox.Show("saldo " + saldo);
        }

        private void btnAvaliarSaldo_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void btnValidarVoto_Click(object sender, EventArgs e)
        {
            int idade = 18;
            bool brasileira = true;

            if (idade >= 16 && brasileira)
                MessageBox.Show("Apta a votar");
            else
                MessageBox.Show("Não está apta a votar");
        }

        private void btnCalcImposto_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 100.0;
            double imposto;

            if (valorDaNotaFiscal <= 999)
                imposto = (valorDaNotaFiscal / 100) * 2;
            else if (valorDaNotaFiscal <= 2999)
                imposto = (valorDaNotaFiscal / 100) * 2.5;
            else if (valorDaNotaFiscal <= 6999)
                imposto = (valorDaNotaFiscal / 100) * 2.8;
            else
                imposto = (valorDaNotaFiscal / 100) * 3;

            MessageBox.Show("Imposto: " + imposto);
        }

        private void btnAvaliarNum_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";

            mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";

            MessageBox.Show(mensagem);
        }
    }
}
