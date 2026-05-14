using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9P8
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            Saldo -= Convert.ToDouble(valor + 0.05);
        }

        public override void Deposita(double valor)
        {
            Saldo += Convert.ToDouble(valor - 0.10);
        }
    }
}
