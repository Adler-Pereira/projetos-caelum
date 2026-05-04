using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercicios5P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void btnSoma1A1000_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 1000; i++) soma += i;

            MessageBox.Show("Soma dos números de 1 até 1000: " + soma);
        }

        private void btnMult3De1A100_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) MessageBox.Show(Convert.ToString(i));
            }
        }

        private void btnSomaSemMult3_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0) soma += i;
            }

            MessageBox.Show("Soma dos números de 1 até 100 (sem múltiplos de 3): " + soma);
        }

        private void btnDivisores_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0) MessageBox.Show(Convert.ToString(i));
            }
        }

        private void btnFatoriais_Click(object sender, EventArgs e)
        {
            int fatorial = 1;


            MessageBox.Show("O fatorial de 0! é " + fatorial);

            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                MessageBox.Show("O fatorial de " + i + "! é " + fatorial);
            }
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int elem1 = 0;
            int elem2 = 1;
            int res = 0;

            while (elem1 <= 101)
            {
                elem1 = res;
                MessageBox.Show(Convert.ToString(elem1));
                res = elem1 + elem2;
                elem2 = elem1;
            }
        }

        private void btnForsEncadeados_Click(object sender, EventArgs e)
        {
            int res = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    res += i;
                    Console.Write(res + " ");
                }
                res = 0;
                Console.WriteLine();
            }

            MessageBox.Show("Verifique o console (saída de depuração).");
        }
    }
}
