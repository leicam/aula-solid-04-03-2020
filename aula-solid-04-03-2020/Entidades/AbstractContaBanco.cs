using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Entidades
{
    internal abstract class AbstractContaBanco
    {
        public Pessoa Pessoa { get; protected set; } 
        public decimal Saldo { get; protected set; }

        public AbstractContaBanco(Pessoa pessoa)
        {
            Pessoa = pessoa;
            Saldo = 0.0m;
        }

        public abstract void Saque(decimal valor);
        public abstract void Deposito(decimal valor);

        public void GetSaldo()
            => Console.WriteLine($"{Pessoa.Nome} seu saldo é de {Saldo}");
    }
}
