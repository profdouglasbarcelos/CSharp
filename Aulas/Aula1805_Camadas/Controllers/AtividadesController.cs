using Aula1805_Camadas.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aula1805_Camadas.Controllers
{
    class AtividadesController
    {
        List<Atividade> minhasAtividades = new List<Atividade>();

        public int UltimoIdUtilizado { get; private set; }

        public AtividadesController()
        {
            UltimoIdUtilizado = 0;
        }

        // Salvar
        public void Salvar(Atividade atividade)
        {
            UltimoIdUtilizado++;
            atividade.AtividadeID = UltimoIdUtilizado;
            minhasAtividades.Add(atividade);
        }

        // Listar
        public List<Atividade> Listar()
        {
            return minhasAtividades;
        }

        // BuscarPorID
        public Atividade BuscarPorId(int id)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
            }
            return null;
        }

        //BuscarPorNome
        public List<Atividade> BuscarPorNome(string nome)
        {
            //LINQ
            IEnumerable<Atividade> atividadesSelecionadas = from a in minhasAtividades
                                                            where a.Nome.ToLower().Contains(nome.ToLower())
                                                            select a;

            return atividadesSelecionadas.ToList();

            // versao pre historica

            //List<Atividade> atividadesSelecionadas = new List<Atividade>();

            //foreach (Atividade a in minhasAtividades)
            //{
            //    if (a.Nome.ToLower().Contains(nome.ToLower()))
            //    {
            //        atividadesSelecionadas.Add(a);
            //    }
            //}

            //return atividadesSelecionadas;
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
