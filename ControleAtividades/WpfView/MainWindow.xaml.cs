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

namespace WpfView
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

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            btnSalvar.Content = "bla bla bla";
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            btnSalvar.Visibility = Visibility.Hidden;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btnSalvar.Visibility = Visibility.Visible;
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNome.Text.Length > 3)
                MessageBox.Show("Voce escreveu: " + txtNome.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroUsuario cadUsu = new CadastroUsuario();
            cadUsu.Show();
            //cadUsu.ShowDialog();
            this.Close();
        }
    }
}
