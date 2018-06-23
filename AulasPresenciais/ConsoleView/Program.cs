using Controllers;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController alunosController = new AlunosController();

            // Cadastrando alunos
            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }

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
