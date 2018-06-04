using Modelos;
using System.Collections.Generic;

namespace Controllers.Base
{
    interface IBaseController<T> where T : class
    {
        void Adicionar(T entity);
        IList<T> ListarTodos();

        IList<T> ListarPorNome(string nome);

        T BuscarPorID(int id);

        void Editar(T entity);

        void Excluir(int id);

    }
}
