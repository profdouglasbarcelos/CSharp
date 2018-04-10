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

namespace MeuProjetoWPF
{
    /// <summary>
    /// Interaction logic for TelaCadastro.xaml
    /// </summary>
    public partial class TelaCadastro : Window
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void txtNome_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                btnSalvar.IsEnabled = true;
            }
            else
                btnSalvar.IsEnabled = false;
        }
    }
}
