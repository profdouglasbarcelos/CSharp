using Aula1805_Camadas.Models;
using System.Collections.Generic;

namespace Aula1805_Camadas.Controllers
{
    class AtividadesController
    {
        List<Atividade> minhasAtividades = new List<Atividade>();

        // Salvar
        public void Salvar(Atividade atividade)
        {
            minhasAtividades.Add(atividade);
        }

        // Listar
        public List<Atividade> Listar()
        {
            return minhasAtividades;
        }

        // Editar
        public void Editar(Atividade atividadeAtualizada)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if(a.AtividadeID == atividadeAtualizada.AtividadeID)
                {
                    a.Nome = atividadeAtualizada.Nome;
                    a.Ativo = atividadeAtualizada.Ativo;
                }
            }
        }

        // Excluir
        public void Excluir(Atividade atividade)
        {
            minhasAtividades.Remove(atividade);
        }
    }
}
