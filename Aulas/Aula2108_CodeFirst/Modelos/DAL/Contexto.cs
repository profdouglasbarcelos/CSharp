using System.Data.Entity;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {
                
        }

    }
}
