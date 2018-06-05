using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Editar(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Usuario usu = BuscarPorID(id);

            if(usu != null)
            {
                //1a forma
                //contexto.Entry(usu).State = System.Data.Entity.EntityState.Deleted;

                // 2a forma
                contexto.Usuarios.Remove(usu);


                contexto.SaveChanges();
            }

        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            // LINQ
            //var usuariosComNome = from usu in contexto.Usuarios
            //                      where usu.Nome == nome
            //                      select usu;

            //return usuariosComNome.ToList();

            // LAMBDA
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList();

        }

        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}
