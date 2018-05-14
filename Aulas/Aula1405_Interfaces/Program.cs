using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Console.WriteLine("Velocidade inicial: " + car.Velocidade);
            car.Acelerar();
            car.Acelerar();
            Console.WriteLine("Velocidade Atual: " + car.Velocidade);

            Console.ReadKey();
        }
    }
}
