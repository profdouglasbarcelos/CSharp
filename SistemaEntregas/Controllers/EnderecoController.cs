using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EnderecoController
    {
        static List<Endereco> EnderecosCadastrados = new List<Endereco>();
        static int ultimoId;

        public void SalvarEndereco(Endereco endereco) {
            int id = ultimoId + 1;
            ultimoId = id;

            endereco.EnderecoID = id;
            EnderecosCadastrados.Add(endereco);


        }
    public Endereco PesquisarPorId (int id)
    {
            var e = (
                from x in EnderecosCadastrados
                where x.EnderecoID.Equals(id)
                select x).FirstOrDefault();

            if (e != null)
                return e;
            else return null;

        }

    }
}
