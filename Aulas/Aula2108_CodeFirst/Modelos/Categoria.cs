using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aula2108_CodeFirst.Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        // Relacionamento Categoria <--> Produto

        public virtual ICollection<Produto> _Produtos { get; set; }
    }
}
