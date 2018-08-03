using System;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("BARCO: Acelerando, empurrando manete.");
            Velocidade += 2;
        }

        public void Frenar()
        {
            Console.WriteLine("BARCO: Desacelerando, empurrando manete.");
            Velocidade -= 1;
        }
    }
}
