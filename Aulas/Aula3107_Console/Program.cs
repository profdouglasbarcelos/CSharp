using System;

namespace Aula3107_Console
{
    class Program
    {
        public static int Id { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite um numero");
            Id = int.Parse(Console.ReadLine());
            ImprimirNumeroDigitado(Id);
            Console.ReadKey();
        }

        static void ImprimirNumeroDigitado(int num)
        {
            Console.WriteLine("Voce digitou: " + num);
        }
    }
}
