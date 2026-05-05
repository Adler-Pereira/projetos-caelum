using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios6P7
{
    class Conta
    {
        public double saldo;
        public string titular;
        public int idade_titular;
        public int numero;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (this.saldo >= valor && valor > 0)
            {
                if (idade_titular < 18)
                {
                    if (valor <= 200)
                    {
                        this.saldo -= valor;
                        MessageBox.Show("Saque realizado com sucesso");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Erro: saque acima de R$ 200,00");
                        return false;
                    }
                }

                this.saldo -= valor;
                MessageBox.Show("Saque realizado com sucesso");

                return true;
            }
            MessageBox.Show("Saldo insuficiente");
            return false;
        }

        public bool Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
