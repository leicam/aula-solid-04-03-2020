using aula_solid_04_03_2020.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Interfaces
{
    internal interface IServicoBancario
    {
        void GetSaldo(AbstractContaBanco conta);
        void Depositar(AbstractContaBanco conta, decimal valor);
        void Saque(AbstractContaBanco conta, decimal valor);
    }
}