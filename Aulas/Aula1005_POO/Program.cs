using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.Nome = "Godofredo"; // set
            string nomeCliente = cli.Nome; // get

            cli.Cpf = "12345678909"; // set
            string cpfCliente = cli.Cpf; // get

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);

            // Utilizando os construtores parametrizados
            Cliente cli2 = new Cliente("Jucicreia"); // nome
            Cliente cli3 = new Cliente("Juciliuda", "123"); // nome, cpf



            Console.ReadKey();
        }
    }
}
