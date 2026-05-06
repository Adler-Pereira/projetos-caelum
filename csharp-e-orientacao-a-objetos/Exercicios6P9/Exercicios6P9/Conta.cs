using Exercicios6P9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6P7
{
    class Conta
    {
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
