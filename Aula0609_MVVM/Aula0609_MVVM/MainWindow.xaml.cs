using Aula0609_MVVM.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aula0609_MVVM
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrarAtividade_Click(object sender, RoutedEventArgs e)
        {
            CadastroAtividade cad = new CadastroAtividade();
            cad.Show();
        }

        private void btnListarAtividades_Click(object sender, RoutedEventArgs e)
        {
            ListaAtividades la = new ListaAtividades();
            la.Show();
        }
    }
}
