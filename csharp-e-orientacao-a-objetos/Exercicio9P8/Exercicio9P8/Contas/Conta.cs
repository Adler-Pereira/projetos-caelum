using System;
using System.Windows.Forms;

namespace Exercicio9P8.Contas
{
    public abstract class Conta
    {
        private static int numeroDeContas;
        public Titular Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public override string ToString()
        {
            return this.Titular.Nome;
        }

        public static class ContaExtensions
        {
            public static void MudaTitular(Conta c, Titular titular)
            {
                c.Titular = titular;
            }
        }
    }
}
