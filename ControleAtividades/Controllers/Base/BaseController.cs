using System;
using System.Collections.Generic;

namespace Controllers.Base
{
    public class BaseController<T> : IBaseController<T> where T : class
    {
        public void Adicionar(T entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T entity)
        {
            throw new NotImplementedException();
        }

        public T BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
