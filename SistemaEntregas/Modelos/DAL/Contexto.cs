using System.Data.Entity;

namespace Modelos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("stringConn")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
