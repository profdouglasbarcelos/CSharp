using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Aluno
    {
        [Key]
        public int AlunoID { get; set; }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [Required]
        public int Matricula { get; set; }
    }
}
