using System;

namespace Aula0303_Conceitos
{
    public class Carro : MeioTransporte, IMotorizado
    {
        public Carro(string nome)
        {
            this.Nome = nome;
        }

        public void Acelerar()
        {
            Console.WriteLine("Carro: Acelerando...");
        }

        public void Frear()
        {
            Console.WriteLine("Carro: Freando...");
        }

        public override int Parar()
        {
            int a = base.Parar();
            Console.WriteLine(string.Format("Carro: Parando... (a={0})",a));
            return 0;
        }
    }
}
