using Exercicio9P8.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9P8
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; set; }

        public void Adiciona (Conta conta)
        {
            SaldoTotal += conta.Saldo;
            MessageBox.Show("Saldo Total: " + SaldoTotal);
        }
    }
}
