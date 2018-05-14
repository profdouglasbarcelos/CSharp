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
            car.Desacelerar();
            Console.WriteLine("Velocidade Atual: " + car.Velocidade);

            Console.WriteLine();
            Console.WriteLine();

            Onibus oni = new Onibus();
            Console.WriteLine("Velocidade Inicial: " + oni.Velocidade);
            oni.Acelerar();
            oni.Desacelerar();
            Console.WriteLine("Velocidade Atual: " + oni.Velocidade);


            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());

            AcelerarBastante(oni);
            Console.WriteLine(oni.ImprimirInfo());


            CriarRelacionamentos();


            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }

        static void CriarRelacionamentos()
        {
            Carro c = new Carro();
            c.Modelo = "Corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";

            // Atribuindo marca
            c._Marca = m;

            // criando e armazenando rodas
            c.Rodas = new List<Roda>();
            Roda r1 = new Roda();
            c.Rodas.Add(r1);

            for (int i = 0; i < 3; i++)
            {
                c.Rodas.Add(new Roda());
            }

            Console.WriteLine("Qtd rodas: " + c.Rodas.Count);

            Onibus o = new Onibus();
            o.Modelo = "3100";

            o._Marca = m;

        }
    }
}
