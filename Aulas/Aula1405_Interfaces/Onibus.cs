using System;

namespace Aula1405_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 6;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return "Ônibus, velocidade atual: " + Velocidade;
        }
    }
}
