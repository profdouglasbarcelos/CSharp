using Controllers.Base;
using Modelos;
using System.Collections.Generic;
using System;
using Controllers.DAL;
using System.Linq;

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

        public void Atualizar(Usuario entity)
        {
            contexto.Entry(entity).State = 
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Excluir(int id)
        {
            Usuario u = BuscarPorID(id);

            if(u != null)
            {
                contexto.Usuarios.Remove(u);
                contexto.SaveChanges();
            }
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            return contexto.Usuarios
                .Where(u => u.Nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}
