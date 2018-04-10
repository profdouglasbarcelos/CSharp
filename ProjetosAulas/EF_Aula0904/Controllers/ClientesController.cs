using EF_Aula0904.Models;
using EF_Aula0904.Models.DAL;
using System.Collections.Generic;
using System.Linq;

namespace EF_Aula0904.Controllers
{
    public class ClientesController
    {
        // INSERT
        public static void SalvarCliente(Cliente cliente)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Clientes.Add(cliente);
            bancoDados.SaveChanges();
        }

        // SELECT *
        public static List<Cliente> ListarTodosClientes()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Clientes.ToList();
        }


        // SELECT BY ID
        public static Cliente CarregarPorID(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Clientes.Find(id);
        }

        public static void EditarCliente(int id, Cliente novoCliente)
        {
            MeuContexto bancoDados = new MeuContexto();
            Cliente clienteAtual = bancoDados.Clientes.Find(id);

            clienteAtual.Nome = novoCliente.Nome;
            clienteAtual.CPF = novoCliente.CPF;

            bancoDados.Entry(clienteAtual).State = 
                System.Data.Entity.EntityState.Modified;

            bancoDados.SaveChanges();
        }

        public static void ExcluirCliente(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Cliente clienteAtual = bancoDados.Clientes.Find(id);

            bancoDados.Entry(clienteAtual).State =
                System.Data.Entity.EntityState.Deleted;

            bancoDados.SaveChanges();

        }
    }
}
