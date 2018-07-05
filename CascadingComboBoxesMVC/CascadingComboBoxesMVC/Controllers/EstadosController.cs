using CascadingComboBoxesMVC.Controllers.DAL;
using CascadingComboBoxesMVC.Models;
using System.Collections.Generic;

namespace CascadingComboBoxesMVC.Controllers
{
    public class EstadosController
    {
        Contexto ctx = new Contexto();
        public List<Estado> ListarTodos()
        {
            return ctx.Estados;
        }
    }
}
