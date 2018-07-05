using CascadingComboBoxesMVC.Controllers.DAL;
using CascadingComboBoxesMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace CascadingComboBoxesMVC.Controllers
{
    public class CidadesController
    {
        Contexto ctx = new Contexto();

        public List<Cidade> ListarTodos()
        {
            return ctx.Cidades;
        }

        public List<Cidade> ListarPorEstado(int estadoID)
        {
            return ctx.Cidades.Where(c => c.EstadoID == estadoID).ToList();
        }
    }
}
