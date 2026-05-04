using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios3P5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeJose = 42;

            int media = calcMedia(idadeJoao, idadeMaria, idadeJose);

            MessageBox.Show("A média das idades é: " + media);
        }

        private void btnVerPi_Click(object sender, EventArgs e)
        {
            // A linha abaixo dá erro de compilação.
            // int pi = 3.14;
        }

        private void btnConvPi_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private int calcMedia(int idade1, int idade2, int idade3)
        {
            int resultado = (idade1 + idade2 + idade3) / 3;

            return resultado;
        }

        private void btnCalcBhaskara_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = -7;
            int c = 3;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("a1 = " + a1 + "\na2 = " + a2);
        }
    }
}
