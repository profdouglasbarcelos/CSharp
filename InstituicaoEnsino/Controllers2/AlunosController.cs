using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers2
{
    public class AlunosController
    {
        public static void AdicionarAluno(Aluno aluno)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Alunos.Add(aluno);
                ctx.SaveChanges();
            }
        }

        private static Aluno BuscarAlunoPorID(int id, Contexto ctx)
        {
            return ctx.Alunos.Find(id);
        }

        public static void EditarAluno(int id, Aluno novosDadosAluno)
        {
            using (Contexto ctx = new Contexto())
            {
                Aluno dadosAntigosAluno = BuscarAlunoPorID(id, ctx);

                if(dadosAntigosAluno != null)
                {
                    dadosAntigosAluno.Nome = novosDadosAluno.Nome;
                    dadosAntigosAluno.Cpf = novosDadosAluno.Cpf;

                    ctx.Entry(dadosAntigosAluno).State = 
                        System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public static void ExcluirAluno(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Aluno a = BuscarAlunoPorID(id, ctx);

                if(a != null)
                {
                    ctx.Entry(a).State =
                        System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }

        public static List<Aluno> ListarTodos()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Alunos.ToList();
            }
        }
    }
}
