using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        public int ExibirMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("= Escolha uma opcao:  =");
            Console.WriteLine("= 1) Criar Atividade  =");
            Console.WriteLine("= 2) Listar Atividades =");
            Console.WriteLine("= 3) Buscar Atividade =");
            Console.WriteLine("= 4) Editar Atividade =");
            Console.WriteLine("= 5) Excluir Atividade =");
            Console.WriteLine("======================");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        public void CriarAtividade()
        {
            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);
        }
    }
}
