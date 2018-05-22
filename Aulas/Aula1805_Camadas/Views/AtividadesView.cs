using Aula1805_Camadas.Controllers;
using Aula1805_Camadas.Models;
using System;
using System.Collections.Generic;

namespace Aula1805_Camadas.Views
{
    class AtividadesView
    {
        enum OpcoesMenu
        {
            CadastrarAtividade = 1,
            ListarAtividades = 2,
            EditarAtividade = 3,
            ExcluirAtividade = 4,
            BuscarAtividadePorNome = 5,
            Sair = 6
        }


        AtividadesController ac = new AtividadesController();


        public void ExibirMenu()
        {
            OpcoesMenu opcao = OpcoesMenu.Sair;

            do
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("= 1) Cadastrar Atividade =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Editar Atividade =");
                Console.WriteLine("= 4) Excluir Atividade ");
                Console.WriteLine("= 5) Buscar Atividade por Nome");
                Console.WriteLine("= 6) -- Sair -- ");
                Console.WriteLine("=====================================");

                Console.Write("Digite sua opcao: ");
                opcao = (OpcoesMenu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case OpcoesMenu.CadastrarAtividade:
                        CadastrarAtiviade();
                        break;
                    case OpcoesMenu.ListarAtividades:
                        ExibirAtividadesCadastradas();
                        break;
                    case OpcoesMenu.EditarAtividade:
                        EditarAtividadeCadastrada();
                        break;
                    case OpcoesMenu.ExcluirAtividade:
                        ExcluirAtividadeCadastrada();
                        break;
                    case OpcoesMenu.BuscarAtividadePorNome:
                        BuscarAtividadePorNome();
                        break;
                    case OpcoesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine("*** Opcao invalida ***");
                        break;
                }

            } while (opcao != OpcoesMenu.Sair);
        }

        private void BuscarAtividadePorNome()
        {
            Console.Write("Digite o nome da atividade a ser pesquisada: ");
            string nomeAtividade = Console.ReadLine();

            List<Atividade> atividades = ac.BuscarPorNome(nomeAtividade);

            Console.WriteLine("--- Exibindo a lista das atividade pesquisadas ---");

            if (atividades.Count > 0)
            {
                foreach (Atividade a in atividades)
                {
                    ExibirDetalhesAtividade(a);
                }
            }
            else
                Console.WriteLine("** Nao ha atividades com o nome: " + nomeAtividade + "**");

            Console.WriteLine("--- Fim da lista das atividade pesquisadas ---");
            Console.ReadKey();
        }

        private void ExcluirAtividadeCadastrada()
        {
            Console.Clear();

            ExibirAtividadesCadastradas();

            Console.WriteLine("-- Excluir atividade cadastrada -- ");

            Console.Write("Digite o id da atividade a ser excluida: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = ac.BuscarPorId(id);

            if (atividade != null)
                ac.Excluir(atividade);
            else
                Console.WriteLine("Atividade não encontrada");
        }

        private void EditarAtividadeCadastrada()
        {
            Console.Clear();
            ExibirAtividadesCadastradas();

            Console.WriteLine("-- Editar atividade cadastrada -- ");

            Atividade atividade = new Atividade();
            Console.Write("Digite o id da atividade a ser alterada: ");
            atividade.AtividadeID = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome: ");
            atividade.Nome = Console.ReadLine();

            Console.Write("Ativo? (s/n)");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;

            ac.Editar(atividade);
        }

        private void ExibirAtividadesCadastradas()
        {
            Console.Clear();
            Console.WriteLine("-- Exibindo atividades cadastradas -- ");

            foreach (Atividade a in ac.Listar())
            {
                ExibirDetalhesAtividade(a);
            }
            Console.WriteLine("-- Fim da lista --");
        }

        private static void ExibirDetalhesAtividade(Atividade a)
        {
            Console.WriteLine("- Dados Atividade - ");
            Console.WriteLine(" Id: " + a.AtividadeID);
            Console.WriteLine(" Nome: " + a.Nome);
            Console.WriteLine(" Ativo: " + a.Ativo);
            Console.WriteLine("--");
        }

        private void CadastrarAtiviade()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastrando nova atividade -- ");
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            ac.Salvar(atividade);
        }
    }
}
