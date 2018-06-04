using System.Collections.Generic;
using Controllers.Base;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        public void Adicionar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public Usuario BuscarPorID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
