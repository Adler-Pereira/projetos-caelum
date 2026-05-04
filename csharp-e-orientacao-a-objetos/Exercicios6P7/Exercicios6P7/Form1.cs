using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios6P7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.saldo = 1000.0;

            c.saldo += 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.titular = "victor";
            contaVictor.numero = 1;
            contaVictor.Deposita(100);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
            contaVictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
        }

        private void btnSacaDeposita_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000;

            Conta guilherme = new Conta();
            guilherme.saldo = 5000;

            mauricio.saldo -= 200.0;
            guilherme.saldo += 200.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("guilherme = " + guilherme.saldo);
        }

        private void btnMauricioIgual_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio == mauricio2) MessageBox.Show("As contas são iguais");
            else MessageBox.Show("As contas são diferentes");
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
        }
    }
}
