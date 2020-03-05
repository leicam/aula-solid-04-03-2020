using aula_solid_04_03_2020.Entidades;
using aula_solid_04_03_2020.Interfaces;
using aula_solid_04_03_2020.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020
{
    class Program
    {
        private static readonly IServicoBancario _servicoBancario = new ServicoBancario();

        static void Main(string[] args)
        {
            var pessoa = new Pessoa("00000000000", "Juliano", "juliano@mail.com");
            EmailService
                .EnviarEmail(pessoa);

            Console.WriteLine("\n");

            var contaPoupanca = new ContaPoupanca(pessoa);

            _servicoBancario.Depositar(contaPoupanca, 10.00m);
            _servicoBancario.Saque(contaPoupanca, 10.00m);
            _servicoBancario.GetSaldo(contaPoupanca);

            Console.ReadLine();
        }
    }
}