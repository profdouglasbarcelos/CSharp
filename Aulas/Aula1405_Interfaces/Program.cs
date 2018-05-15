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

            

            AcelerarBastante(c);
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            Console.ReadKey();

        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
