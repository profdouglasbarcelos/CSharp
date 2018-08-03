using System;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerando pela manopla.");
            Velocidade += 10;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Frenando pelo pedal e manopla.");
            Velocidade -= 2;
        }
    }
}
