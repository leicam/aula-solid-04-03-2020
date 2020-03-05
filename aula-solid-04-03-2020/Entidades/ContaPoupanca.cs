using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Entidades
{
    internal class ContaPoupanca : AbstractContaBanco
    {
        public ContaPoupanca(Pessoa pessoa) : base(pessoa) { }

        public override void Saque(decimal valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"{Pessoa.Nome} saldo indisponivel para saque!");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado na conta poupança!");
        }

        public override void Deposito(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito de {valor} realizado na conta poupança!");
        }
    }
}
