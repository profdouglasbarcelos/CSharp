using Aula2806_CrudMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2806_CrudMVVM.Views
{
    public class NovoCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is FuncionariosViewModel;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (FuncionariosViewModel)parameter;
            var funcionario = new Models.Funcionario();
            var maxId = 0;
            if (viewModel.Funcionarios.Any())
            {
                maxId = viewModel.Funcionarios.Max(f => f.Id);
            }
            funcionario.Id = maxId + 1;

            var fw = new CadastroFuncionario();
            fw.DataContext = funcionario;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.Funcionarios.Add(funcionario);
                viewModel.FuncionarioSelecionado = funcionario;
            }
        }
    }
}
