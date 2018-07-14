using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro novoCarro = new Carro();

            novoCarro.Acelerar();
            novoCarro.Acelerar();

            //string.Format("{0} {1} {2}", "velocidade", "novoCarro", novoCarro.Velocidade);

            Console.WriteLine("velocidade novoCarro: " + novoCarro.Velocidade);

            Carro carro2 = new Carro(5);
            carro2.Acelerar();
            carro2.Frenar();

            Console.WriteLine("velocidade carro2: " + carro2.Velocidade);


            Console.ReadKey();
        }
    }
}
