using EF_Aula0904.Models;
using EF_Aula0904.Models.DAL;

namespace EF_Aula0904.Controllers
{
    public class ClientesController
    {
        public static void SalvarCliente(Cliente cliente)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Clientes.Add(cliente);
            bancoDados.SaveChanges();
        }
    }
}
