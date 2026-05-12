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
            base.Saca(valor + 0.10);
        }
    }
}
