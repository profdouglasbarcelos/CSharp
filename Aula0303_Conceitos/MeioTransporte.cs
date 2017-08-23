using System;

namespace Aula0303_Conceitos
{
    public abstract class MeioTransporte
    {
        public string Nome { get; set; }
        public int Ano { get; set; }
        public int Capacidade { get; set; }

        public virtual int Parar()
        {
            Console.WriteLine("MeioTransporte: Parando...");
            return 1;
        }

    }
}
