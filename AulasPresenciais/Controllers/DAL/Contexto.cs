using Modelos;
using System.Data.Entity;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn") // base = (super do Java), "strConn" = nome da conexão com banco
        {

        }

        public DbSet<Aluno> Alunos { get; set; } // tabela de alunos
    }
}
