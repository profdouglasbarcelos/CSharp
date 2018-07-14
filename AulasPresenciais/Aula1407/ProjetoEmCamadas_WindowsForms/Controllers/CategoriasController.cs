using ProjetoEmCamadas_WindowsForms.DAL;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEmCamadas_WindowsForms.Controllers
{
    class CategoriasController
    {
        LojaDBContainer contexto = new LojaDBContainer();

        public void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        }
    }
}
