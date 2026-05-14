using System;
using System.Windows.Forms;

namespace Exercicio9P8
{
    public abstract class Conta
    {
        public Titular Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);
    }
}