using Exercicio9P8.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9P8
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                Saldo -= valor + 0.10;
            }
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo += valor;
            }
        }
    }
}
