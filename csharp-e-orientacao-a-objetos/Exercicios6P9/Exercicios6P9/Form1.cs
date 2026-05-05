using Exercicios6P7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios6P9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.nome = "Guilherme Silveira";
            umaConta.titular = guilherme;

            MessageBox.Show(umaConta.titular.nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.rg = "12345678-9";

            umaConta.titular = guilherme;
            umaConta.titular.rg = "98765432-1";

            MessageBox.Show(guilherme.rg);
        }
    }
}
