using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        private static int Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");

            Console.WriteLine(" - Geral -");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");

            //return Convert.ToInt32(Console.ReadLine());
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int opcaoDigitada = Menu();

           

            Console.ReadKey();
        }
    }
}
