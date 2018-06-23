using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = CadastrarAluno();
            ImprimirDadosAluno(a);

            Console.ReadKey();
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome); // get
            Console.WriteLine("Matricula: " + a.Matricula); //get
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a.Nome = Console.ReadLine(); //set

            Console.Write("Digite o numero da matricula: ");
            a.Matricula = int.Parse(Console.ReadLine()); //set

            return a;
        }
    }
}
