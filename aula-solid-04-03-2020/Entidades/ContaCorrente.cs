using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Entidades
{
    internal class ContaCorrente : AbstractContaBanco
    {
        public ContaCorrente(Pessoa pessoa) : base(pessoa) { }

        public override void Deposito(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Saque(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
