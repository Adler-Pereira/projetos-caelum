using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6P9
{
    internal class Cliente
    {
        public string nome;
        public int idade;
        public string rg;
        public string cpf;
        public string endereco;

        public bool EhMaiorDeIdade(int idade)
        {
            if (idade >= 18) return true;
            return false;
        }
    }
}
