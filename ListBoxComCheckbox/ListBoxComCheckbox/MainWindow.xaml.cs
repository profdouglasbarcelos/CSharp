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

namespace ListBoxComCheckbox
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

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();

            // Criando uma lista ficticia para simular dados salvos no banco
            for (int i = 0; i < 5; i++)
            {
                Aluno a = new Aluno();
                a.Nome = txtNome.Text + i;
                a.Matricula = "Matrícula: " + i.ToString();
                alunos.Add(a);
            }

            lbxAlunos.ItemsSource = alunos;
        }
    }
}
