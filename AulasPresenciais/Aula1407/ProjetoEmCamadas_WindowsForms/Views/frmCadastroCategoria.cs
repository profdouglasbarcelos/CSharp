using ProjetoEmCamadas_WindowsForms.Controllers;
using ProjetoEmCamadas_WindowsForms.DAL;
using System;
using System.Windows.Forms;

namespace ProjetoEmCamadas_WindowsForms.Views
{
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categ = new Categoria();
            categ.Nome = txtNome.Text;

            CategoriasController catController = new CategoriasController();
            catController.Adicionar(categ);
        }
    }
}
