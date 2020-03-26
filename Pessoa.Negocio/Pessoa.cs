using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa.Negocio
{
    class Pessoa
    {
        public string nomeCompleto { get; private set; }

        public DateTime dataNascimento { get; set; }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            nome = nome;
            dataNascimento = dataNascimento;
        }  

       
    }
}
