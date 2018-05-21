using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        private AtividadesController atividadeController;
        
        enum OpcoesMenu
        {
            CriarAtividade = 1,
            ListarAtividades = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5,
            Sair = 9
        }

        public AtividadesView()
        {
            atividadeController = new AtividadesController();
        }



        public void ExibirMenu()
        {
            OpcoesMenu opcao = OpcoesMenu.Sair;

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
                Console.WriteLine("= 6) Buscar atividade por Nome =");
                Console.WriteLine("= 7) Listar Atividades (Ativos/Inativos) =");

                Console.WriteLine("= 9) Sair ");
                Console.WriteLine("======================");

                opcao = (OpcoesMenu) int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case OpcoesMenu.CriarAtividade:
                        CriarAtividade();
                        break;
                    case OpcoesMenu.ListarAtividades:
                        ListarAtividades();
                        break;
                    case OpcoesMenu.BuscarAtividade:
                        BuscarAtividade();
                        break;
                    case OpcoesMenu.EditarAtividade:
                        EditarAtividade();
                        break;
                    case OpcoesMenu.ExcluirAtividade:
                        ExcluirAtividade();
                        break;
                    case OpcoesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine("Opcao invalida! Digite qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != OpcoesMenu.Sair);


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

            Console.Write("Ativo? (s/n): ");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;

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
