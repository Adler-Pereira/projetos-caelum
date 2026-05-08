using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta()
        {
            
        }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
