using System;

namespace Aula1105_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.Nome = "Godofredo"; // set
            //a.Cpf = "12345678909";
            Console.WriteLine("Aluno:" + a.Nome); // get

            Aluno b = new Aluno("Juciliuda", "123");
            b.Matricula = "54321";

            Console.WriteLine(b.ShowInfoPessoa());

            //Console.WriteLine("Aluno " + b.Nome + ", Cpf" + b.Cpf);

            Aluno c = new Aluno("Janacreia");

            //Pessoa p = new Pessoa();

            Console.ReadKey();
            
        }
    }
}
