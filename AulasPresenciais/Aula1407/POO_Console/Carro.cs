using System;

namespace POO_Console
{
    class Carro : IVeiculo
    {
        private int _velocidade;
        public int Velocidade
        {
            get
            {
                return _velocidade;
            }

            set
            {
                _velocidade = value;
            }
        }


        public void Acelerar()
        {
            _velocidade = _velocidade + 10;
        }

        public void Frenar()
        {
            _velocidade = _velocidade - 7;
        }
    }
}
