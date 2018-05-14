using System;

namespace Aula1405_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }


        // chave para objeto Marca
        public int MarcaID { get; set; }

        // Propriedade de navegacao
        public virtual Marca _Marca { get; set; }


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
