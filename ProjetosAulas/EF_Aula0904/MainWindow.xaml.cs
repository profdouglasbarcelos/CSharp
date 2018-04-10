using EF_Aula0904.Controllers;
using EF_Aula0904.Models;
using System.Windows;

namespace EF_Aula0904
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

        private void btnSalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            SalvarCliente();
        }

        private void SalvarCliente()
        {
            // Validar os campos
            Cliente cli = new Cliente();
            cli.Nome = "Godofredo"; // txtNome.Text;
            cli.CPF = "12345678909";

            ClientesController.SalvarCliente(cli);
        }
    }
}
