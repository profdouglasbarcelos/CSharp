using Aula2806_CrudMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2806_CrudMVVM.ViewModels
{
    public class FuncionariosViewModel : BaseNotifyPropertyChanged
    {
        //Commands
        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();
        public NovoCommand Novo { get; private set; } = new NovoCommand();

        public System.Collections.ObjectModel.ObservableCollection<Models.Funcionario> Funcionarios { get; private set; }

        private Models.Funcionario _funcionarioSelecionado;
        public Models.Funcionario FuncionarioSelecionado
        {
            get { return _funcionarioSelecionado; }
            set
            {
                SetField(ref _funcionarioSelecionado, value);
                Deletar.RaiseCanExecuteChanged();
            }
        }

        public FuncionariosViewModel()
        {
            Funcionarios = new System.Collections.ObjectModel.ObservableCollection<Models.Funcionario>();
            Funcionarios.Add(new Models.Funcionario()
            {
                Id = 1,
                Nome = "Douglas",
                Sobrenome = "Barcelos",
                DataNascimento = new DateTime(2018, 09, 06),
                Sexo = Models.Sexo.Masculino,
                EstadoCivil = Models.EstadoCivil.Casado,
                DataAdmissao = new DateTime(2010, 1, 1)
            });

            FuncionarioSelecionado = Funcionarios.FirstOrDefault();
        }
    }
}
