using Modelos;
using Modelos.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
//        static List<Cliente> MeusClientes = new List<Cliente>();
//        static int ultimoID = 0;

        public void SalvarCliente(Cliente cliente)
        {
            
            ContextoSingleton.Instancia.Clientes.Add(cliente);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public Cliente PesquisarPorNome(string nome)
        {
            var c = from x in ContextoSingleton.Instancia.Clientes
                    where x.Nome.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        public Cliente PesquisarPorID(int idCliente)
        {
            return ContextoSingleton.Instancia.Clientes.Find(idCliente);
        }

        public void ExcluirCliente(int idCliente)
        {

            Cliente c = ContextoSingleton.Instancia.Clientes.Find(idCliente);

            ContextoSingleton.Instancia.Entry(c).State = 
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            return ContextoSingleton.Instancia.Clientes.ToList();
        }

        public void EditarCliente(int idClienteEditar, Cliente clienteEditado)
        {
            Cliente clienteEditar = PesquisarPorID(idClienteEditar);

            if (clienteEditar != null)
            {
                clienteEditar.Nome = clienteEditado.Nome;
                clienteEditar.Cpf = clienteEditado.Cpf;

                ContextoSingleton
                    .Instancia
                    .Entry(clienteEditar).State =
                    System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();
            }
        }
    }
}
