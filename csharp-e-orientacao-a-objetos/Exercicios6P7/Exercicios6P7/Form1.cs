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
    }
}
