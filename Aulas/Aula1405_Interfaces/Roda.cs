using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Roda
    {
        public int RodaID { get; set; }

        public string Modelo { get; set; }

        public int MarcaID { get; set; }

        public Marca _Marca { get; set; }
    }
}
