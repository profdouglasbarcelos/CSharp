using CascadingComboBoxesMVC.Controllers;
using CascadingComboBoxesMVC.Models;
using System.Windows;
using System.Windows.Controls;

namespace CascadingComboBoxesMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento de carregamento da tela (adicionado na tela de propriedades)
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EstadosController ec = new EstadosController();
            cbxEstados.ItemsSource = ec.ListarTodos();
        }


        // Evento de troca de estado na combobox (adicionado na tela de propriedades)
        private void cbxEstados_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // recuperando o item selecionado (estado)
            Estado estado = (Estado) ((ComboBox)sender).SelectedItem;

            CidadesController cc = new CidadesController();

            cbxCidades.DisplayMemberPath = "Nome";
            cbxCidades.SelectedValuePath = "CidadeID";
            cbxCidades.ItemsSource = cc.ListarPorEstado(estado.EstadoID);
        }
    }
}
