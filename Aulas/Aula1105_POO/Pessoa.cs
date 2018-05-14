using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    abstract class Pessoa
    {
        // Atributos
        private string nome;

        //Propriedades
        public string Nome
        {
            get => nome; // get { return nome; }
            set => nome = value; // set { nome = value; }
        }

        public string Cpf { get; private set; }


        // Construtor
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public abstract string ShowInfoPessoa();
    }
}
