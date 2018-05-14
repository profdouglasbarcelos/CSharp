using System;
using System.Collections.Generic;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }

        // chave para objeto Marca
        public int MarcaID { get; set; }

        // Propriedade de navegacao
        public virtual Marca _Marca { get; set; }


        public List<Roda> Rodas { get; set; }


        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro, velocidade atual: " + Velocidade;
        }
    }
}
