using System;

namespace Aula1_2802
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite seu nome");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Olá " + p.Nome);

            Console.ReadKey();
        }
    }
}
