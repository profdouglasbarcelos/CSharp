using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Aluno
    {
        [Key]
        public int AlunoID { get; set; }

        [Required, StringLength(50)]
        public string Nome { get; set; }
        
        [Required, StringLength(11)]
        public string Cpf { get; set; }
    }
}
