using Aula2806_CrudMVVM.ViewModels;

namespace Aula2806_CrudMVVM.Views
{
    public class EditarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as FuncionariosViewModel;
            return viewModel != null && viewModel.FuncionarioSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (FuncionariosViewModel)parameter;
            var cloneFuncionario = (Models.Funcionario)viewModel.FuncionarioSelecionado.Clone();
            var fw = new CadastroFuncionario();
            fw.DataContext = cloneFuncionario;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.FuncionarioSelecionado.Nome = cloneFuncionario.Nome;
                viewModel.FuncionarioSelecionado.Sobrenome = cloneFuncionario.Sobrenome;
                viewModel.FuncionarioSelecionado.DataNascimento = cloneFuncionario.DataNascimento;
                viewModel.FuncionarioSelecionado.Sexo = cloneFuncionario.Sexo;
                viewModel.FuncionarioSelecionado.EstadoCivil = cloneFuncionario.EstadoCivil;
                viewModel.FuncionarioSelecionado.DataAdmissao = cloneFuncionario.DataAdmissao;
            }
        }
    }
}
