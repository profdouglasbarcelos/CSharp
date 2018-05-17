using Aula1705_Camadas.Models;
using System.Collections.Generic;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        // simulando tabela
        public List<Atividade> ListaAtividades { get; set; }
        
        
        //Salvar
        public void Salvar(Atividade atividade)
        {
            ListaAtividades.Add(atividade);
        }

        //Listar
        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }

        //BuscarPorID
        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in ListaAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
            }

            return null;
        }

        //Editar
        //Excluir
    }
}
