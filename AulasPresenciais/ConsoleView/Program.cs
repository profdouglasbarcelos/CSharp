

using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Godofredo"; //set
            a.Matricula = 123; // set

            Console.WriteLine("Aluno: " + a.Nome); // get

            Console.ReadKey();
        }
    }
}
