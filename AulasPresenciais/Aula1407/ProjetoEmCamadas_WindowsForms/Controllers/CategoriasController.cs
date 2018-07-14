using ProjetoEmCamadas_WindowsForms.DAL;

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
    }
}
