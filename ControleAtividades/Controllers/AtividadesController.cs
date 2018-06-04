using System;
using System.Collections.Generic;
using Controllers.Base;
using Modelos;
using Controllers.DAL;
using System.Linq;

namespace Controllers
{
    public class AtividadesController : IBaseController<Atividade>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Atividade entity)
        {
            contexto.Atividades.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Atividade entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Atividade BuscarPorID(int id)
        {
            return contexto.Atividades.Find(id);
        }

        public void Excluir(int id)
        {
            Atividade a = BuscarPorID(id);

            if (a != null)
            {
                // forma 1
                contexto.Atividades.Remove(a);

                // forma 2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;

                contexto.SaveChanges();
            }
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            // LINQ
            //var atividadesComNome = from a in contexto.Atividades
            //            where a.Nome.ToLower() == nome.ToLower()
            //            select a;

            //return atividadesComNome.ToList();

            // LAMBDA
            return contexto.Atividades
                .Where(a => a.Nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Atividade> ListarTodos()
        {
            return contexto.Atividades.ToList();
        }
    }
}
