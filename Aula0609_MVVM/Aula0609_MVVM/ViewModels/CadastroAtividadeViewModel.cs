using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Aula0609_MVVM.ViewModels
{
    public class CadastroAtividadeViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region CamposModelAtividade

        private int atividadeID;

        public int AtividadeID
        {
            get { return atividadeID; }

            set
            {
                atividadeID = value;
                NotifyPropertyChanged("AtividadeID");
            }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }

            set
            {
                titulo = value;
                NotifyPropertyChanged("Titulo");
            }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set
            {
                descricao = value;
                NotifyPropertyChanged("Descricao");
            }
        }

        private bool ativo;

        public bool Ativo
        {
            get { return ativo; }
            set
            {
                ativo = value;
                NotifyPropertyChanged("Ativo");
            }
        }

        #endregion


    }
}
