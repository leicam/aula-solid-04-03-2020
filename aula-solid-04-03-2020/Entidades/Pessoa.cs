using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020
{
    internal class Pessoa
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Pessoa(string documento, string nome, string email)
        {
            Documento = documento ?? throw new Exception("Infotme o documento!");
            Nome = nome ?? throw new Exception("Infotmr o Nome!");
            Email = email ?? throw new Exception("Infotmr o Email!");
        }
    }
}