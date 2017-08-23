using System;
using Aula0303_Conceitos;

namespace Aula0303_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");

            MeioTransporte mt = new Barco();
            ((Barco)mt).QuantidadePes = 10;

            Aula0303_Conceitos.Util.TipoMeioTransporte tipo = (Aula0303_Conceitos.Util.TipoMeioTransporte) Util.Menu();

            switch (tipo)
            {
                case Aula0303_Conceitos.Util.TipoMeioTransporte.Carro:
                    Carro c = new Carro("Fusca");
                    c.Ano = 1978;
                    c.Capacidade = 4;
                    c.Acelerar();
                    c.Frear();
                    c.Parar();
                    break;
                case Aula0303_Conceitos.Util.TipoMeioTransporte.Bicicleta:
                    Bicicleta b = new Bicicleta();
                    b.Nome = "Caloi";
                    b.Ano = 2016;
                    b.Capacidade = 1;
                    b.QuantidadeMarcha = 21;
                    b.Parar();
                    break;
                case Aula0303_Conceitos.Util.TipoMeioTransporte.Barco:
                    Barco ba = new Barco();
                    ba.Ano = 1969;
                    ba.Nome = "Titanic";
                    ba.QuantidadePes = 50;
                    ba.Capacidade = 2000;
                    ((IMotorizado)ba).Acelerar();
                    ((IMotorizado)ba).Frear();
                    ba.Parar();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}