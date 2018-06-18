using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required] // Campo obrigatorio
        [StringLength(30)] // tamanho maximo 30
        public string Nome { get; set; }

        [Required, StringLength(11)]
        public string Cpf { get; set; }

        public bool Ativo { get; set; }
    }
}
