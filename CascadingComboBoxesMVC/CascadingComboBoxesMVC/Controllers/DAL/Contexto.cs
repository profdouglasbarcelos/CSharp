using CascadingComboBoxesMVC.Models;
using System.Collections.Generic;

namespace CascadingComboBoxesMVC.Controllers.DAL
{
    public class Contexto
    {
        public List<Estado> Estados { get; set; } = new List<Estado>();
        public List<Cidade> Cidades { get; set; } = new List<Cidade>();

        public Contexto()
        {
            Estados.Add(new Estado { EstadoID = 1, UF = "PR" });
            Estados.Add(new Estado { EstadoID = 2, UF = "SC" });
            Estados.Add(new Estado { EstadoID = 3, UF = "RS" });

            Cidades.Add(new Cidade { CidadeID = 1, Nome="Curitiba", EstadoID=1 });
            Cidades.Add(new Cidade { CidadeID = 2, Nome="Ponta Grossa", EstadoID=1 });
            Cidades.Add(new Cidade { CidadeID = 3, Nome="Matinhos", EstadoID=1 });
            Cidades.Add(new Cidade { CidadeID = 4, Nome="Florianópolis", EstadoID=2 });
            Cidades.Add(new Cidade { CidadeID = 5, Nome="Baln Camboriú", EstadoID=2 });
            Cidades.Add(new Cidade { CidadeID = 6, Nome="Caxias do Sul", EstadoID=3 });
            Cidades.Add(new Cidade { CidadeID = 7, Nome="Gramado", EstadoID=3 });
            Cidades.Add(new Cidade { CidadeID = 8, Nome="Canela", EstadoID=3 });
        }
    }
}
