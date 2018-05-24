using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    public interface IBaseController<T> where T : class
    {
        void Adicionar(T entity);
        IList<T> ListarTodos();
        IList<T> ListarPorNome(string nome);
        T BuscarPorID(int id);
        void Atualizar(T entity);
        void Excluir(int id);
    }
}
