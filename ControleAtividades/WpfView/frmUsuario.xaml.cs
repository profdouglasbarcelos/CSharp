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
    /// Lógica interna para frmUsuario.xaml
    /// </summary>
    public partial class frmUsuario : Window
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UsuariosController usuariosController = new UsuariosController();

                if (string.IsNullOrEmpty(txtNome.Text))
                    throw new NullReferenceException("O campo nome é obrigatório.");

                Usuario usuario = new Usuario();

                usuario.Nome = txtNome.Text;

                usuariosController.Adicionar(usuario);

                MessageBox.Show("Usuário Salvo com sucesso!");
            }
            catch(NullReferenceException nre)
            {
                // excecao mais especifica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            }
        }
    }
}
