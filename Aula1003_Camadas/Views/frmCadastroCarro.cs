using Aula1003_Camadas.Controllers;
using Aula1003_Camadas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1003_Camadas.Views
{
    public partial class frmCadastroCarro : Form
    {
        public frmCadastroCarro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            c.Nome = txtNome.Text;
            c.Ano = Convert.ToInt32(txtAno.Text);

            CarroController carroController = new CarroController();
            carroController.SalvarCarro(c);
        }
    }
}
