using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Database.SetInitializer<Contexto>(
            //    new DropCreateDatabaseAlways<Contexto>());
        }
        
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
