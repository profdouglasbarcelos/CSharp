using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            valor1 = 10;

            Console.WriteLine("Valor: " + valor1);
            string informacaoUsuario = Console.ReadLine();

            Console.WriteLine("Voce digitou: " + informacaoUsuario);

            Console.ReadKey();
        }
    }
}
