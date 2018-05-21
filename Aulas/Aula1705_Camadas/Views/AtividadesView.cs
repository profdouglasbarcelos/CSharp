using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        private AtividadesController atividadeController;
        
        enum MinhasOpcoes
        {
            CriarAtividade = 1,
            ListarAtividades = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5
        }

        public AtividadesView()
        {
            atividadeController = new AtividadesController();
        }



        public void ExibirMenu()
        {
            int opcao = 9;

            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("= Escolha uma opcao:  =");
                Console.WriteLine("= 1) Criar Atividade  =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Buscar Atividade =");
                Console.WriteLine("= 4) Editar Atividade =");
                Console.WriteLine("= 5) Excluir Atividade =");
                Console.WriteLine("= 9) Sair ");
                Console.WriteLine("======================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CriarAtividade();
                        break;

                    case 2:
                        ListarAtividades();
                        break;

                    case 3:
                        BuscarAtividade();
                        break;

                    case 4:
                        EditarAtividade();
                        break;

                    case 5:
                        ExcluirAtividade();
                        break;


                    default:
                        break;
                }

            } while (opcao != 9);


        }

        private void ExcluirAtividade()
        {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            atividadeController.Editar(id, atividadeAtualizada);
        }

        public void CriarAtividade()
        {
            Atividade atividade = ObterDadosAtividade();

            atividadeController.Salvar(atividade);
        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;
            return atividade;
        }

        private void ListarAtividades()
        {
            Console.WriteLine("Listando atividades cadastradas");
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDetalhesAtividade(atividade);
            }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();
        }
        private void BuscarAtividade()
        {
            Console.Write("Digite o id da atividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorID(id);

            if (atividade != null)
            {
                ExibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada");
            }

            Console.ReadKey();
        }


        private static void ExibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }
    }
}
