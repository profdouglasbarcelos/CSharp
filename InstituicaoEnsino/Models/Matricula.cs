using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Matricula
    {
        public int MatriculaID { get; set; }

        public int AlunoID { get; set; }
        public virtual Aluno _Aluno { get; set; }

        public int CursoID { get; set; }
        //public virtual Curso _Curso { get; set; }

        public DateTime Data { get; set; }

    }
}
