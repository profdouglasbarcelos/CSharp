using Aula0609_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aula0609_MVVM.Views
{
    /// <summary>
    /// Lógica interna para ListaAtividades.xaml
    /// </summary>
    public partial class ListaAtividades : Window
    {
        public ListaAtividades()
        {
            InitializeComponent();

            ListaAtividadesViewModel lavm = new ListaAtividadesViewModel();
            DataContext = lavm;
        }
    }
}
