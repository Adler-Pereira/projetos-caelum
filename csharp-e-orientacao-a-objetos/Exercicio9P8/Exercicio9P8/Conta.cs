using System;
using System.Windows.Forms;

namespace Exercicio9P8
{
    public class Conta
    {
        public Titular Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; set; }

        public virtual void Deposita (double valor)
        {
            Saldo += Convert.ToDouble(valor);
        }

        public virtual void Saca(double valor) {
            Saldo -= Convert.ToDouble(valor);
        }
    }
}