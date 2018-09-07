using Aula0609_MVVM.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Aula0609_MVVM.ViewModels
{
    public class ListaAtividadesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Atividade> Atividades { get; set; }

        public ListaAtividadesViewModel()
        {
            Atividades = new ObservableCollection<Atividade>();

            for (int i = 1; i <= 5; i++)
            {
                Atividades.Add(
                new Atividade()
                {
                    Titutlo = "Atividade " + i,
                    Descricao = "Descricao da atividade " + i,
                    Ativo = i % 2 == 0 ? true : false
                }
                );
            }
            

            
        }
    }
}
