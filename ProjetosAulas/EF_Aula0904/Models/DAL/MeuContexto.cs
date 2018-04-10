using System.Data.Entity;

namespace EF_Aula0904.Models.DAL
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {

        }

        public DbSet<Cliente> tblClientes { get; set; }
    }
}
