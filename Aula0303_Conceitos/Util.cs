using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0303_Conceitos
{
    public class Util
    {
        public enum TipoMeioTransporte
        {
            Carro = 1,
            Bicicleta = 2,
            Barco = 3
        }

        public static int Menu()
        {
            Console.WriteLine("Para criar um carro digite 1");
            Console.WriteLine("Para criar uma bicicleta 2");
            Console.WriteLine("Para criar um barco digite 3");

            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
    }
}
