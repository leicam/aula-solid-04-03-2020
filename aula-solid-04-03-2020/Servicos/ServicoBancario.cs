using aula_solid_04_03_2020.Entidades;
using aula_solid_04_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Servicos
{
    internal class ServicoBancario : IServicoBancario
    {
        public void Depositar(AbstractContaBanco conta, decimal valor)
        {
            conta.Deposito(valor);
        }

        public void GetSaldo(AbstractContaBanco conta)
        {
            conta.GetSaldo();
        }

        public void Saque(AbstractContaBanco conta, decimal valor)
        {
            conta.Saque(valor);
        }
    }
}
