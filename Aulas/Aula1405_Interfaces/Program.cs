using System;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro criado, velocidade inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            Console.ReadKey();

        }
    }
}
