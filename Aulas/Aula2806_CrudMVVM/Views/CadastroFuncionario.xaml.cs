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

namespace Aula2806_CrudMVVM.Views
{
    /// <summary>
    /// Interaction logic for CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroFuncionario : Window
    {
        public CadastroFuncionario()
        {
            InitializeComponent();

            SexoComboBox.ItemsSource = Enum.GetValues(typeof(Models.Sexo)).Cast<Models.Sexo>();
            EstadoCivilComboBox.ItemsSource = Enum.GetValues(typeof(Models.EstadoCivil)).Cast<Models.EstadoCivil>();
            DataNascimentoDatePicker.SelectedDate = DateTime.Today;
            DataAdmissaoDatePicker.SelectedDate = DateTime.Today;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
