using Controllers;
using Modelos;
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

namespace WpfView
{
    /// <summary>
    /// Interaction logic for ListaUsuarios.xaml
    /// </summary>
    public partial class ListaUsuarios : Window
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsuariosController usuariosController = new UsuariosController();
            dgUsuarios.ItemsSource = usuariosController.ListarTodos();
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Usuario usu = (Usuario)dg.Items[dg.SelectedIndex];


        }
    }
}
