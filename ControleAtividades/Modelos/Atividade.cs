using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Atividade
    {
        [Key]
        public int AtividadeID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }

        public int UsuarioID { get; set; }

    }
}
