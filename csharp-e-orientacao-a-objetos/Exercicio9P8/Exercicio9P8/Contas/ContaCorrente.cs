using Exercicio9P8.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9P8
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (valor + 0.05 > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                Saldo -= valor + 0.05;
            }
        }

        public override void Deposita(double valor)
        {
            if (valor - 0.10 < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo += valor - 0.10;
            }
        }

        public double CalculaTributos()
        {
            double imposto = (Saldo / 100) * 5;
            Saldo -= imposto;
            return imposto;
        }
    }
}
