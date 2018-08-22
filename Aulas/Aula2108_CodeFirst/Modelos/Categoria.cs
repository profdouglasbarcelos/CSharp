using System.ComponentModel.DataAnnotations;

namespace Aula2108_CodeFirst.Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
