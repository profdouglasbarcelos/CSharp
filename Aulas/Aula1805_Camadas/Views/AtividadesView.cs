using Aula1805_Camadas.Controllers;
using Aula1805_Camadas.Models;
using System;

namespace Aula1805_Camadas.Views
{
    class AtividadesView
    {
        AtividadesController ac = new AtividadesController();


        public void ExibirMenu()
        {
            int opcao = 6;

            do
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("= 1) Cadastrar Atividade =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Editar Atividade =");
                Console.WriteLine("= 4) Excluir Atividade ");
                Console.WriteLine("= 6) -- Sair -- ");
                Console.WriteLine("=====================================");

                Console.Write("Digite sua opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAtiviade();
                        break;

                    case 2:
                        ExibirAtividadesCadastradas();
                        break;

                    case 3:
                        EditarAtividadeCadastrada();
                    default:
                        break;
                }

                Console.ReadKey();
            } while (opcao != 6);
        }

        private void EditarAtividadeCadastrada()
        {
            
        }

        private void ExibirAtividadesCadastradas()
        {
            Console.WriteLine("-- Exibindo atividades cadastradas -- ");
            foreach (Atividade a in ac.Listar())
            {
                Console.WriteLine("- Dados Atividade - ");
                Console.WriteLine(" Id: " + a.AtividadeID);
                Console.WriteLine(" Nome: " + a.Nome);
                Console.WriteLine(" Ativo: " + a.Ativo);
                Console.WriteLine("--");
            }
            Console.WriteLine("-- Fim da lista --");
        }

        private void CadastrarAtiviade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            ac.Salvar(atividade);
        }
    }
}
