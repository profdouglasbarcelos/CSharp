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

        // Construtor
        public Carro(int veloc)
        {
            _velocidade = veloc;
        }

        public Carro()
        {
            _velocidade = 0;
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
