using ProjetoEmCamadas_WindowsForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmCamadas_WindowsForms.Views
{
    public partial class frmListagemCategorias : Form
    {
        public frmListagemCategorias()
        {
            InitializeComponent();
        }

        private void frmListagemCategorias_Load(object sender, EventArgs e)
        {
            CategoriasController catController = new CategoriasController();
            dgvCategorias.DataSource = catController.Listar();
        }
    }
}
