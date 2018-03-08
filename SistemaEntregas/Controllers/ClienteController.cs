using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    public class ClienteController
    {
        public List<Cliente> MeusClientes { get; set; }

        public ClienteController()
        {
            MeusClientes = new List<Cliente>();
        }




        public void SalvarCliente(Cliente cliente)
        {
            // TODO: Persistir os dados do cliente
            MeusClientes.Add(cliente);
        }
    }
}
