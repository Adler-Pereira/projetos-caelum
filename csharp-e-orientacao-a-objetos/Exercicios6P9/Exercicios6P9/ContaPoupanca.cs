using Exercicios6P7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6P9
{
    class ContaPoupanca : Conta
    {
        public override bool Saca(double valor)
        {
            return base.Saca(valor + 0.10);
        }
    }
}
