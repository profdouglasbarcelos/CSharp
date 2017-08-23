using System;

namespace Aula0303_Conceitos
{
    class Barco : MeioTransporte, IMotorizado
    {
        public int QuantidadePes { get; set; }

        void IMotorizado.Acelerar()
        {
            Console.WriteLine("Barco: Acelerando...");
        }

        void IMotorizado.Frear()
        {
            Console.WriteLine("Barco: Freando...");
        }
    }
}
