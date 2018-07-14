using ProjetoEmCamadas_WindowsForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmCamadas_WindowsForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCategoria = new frmCadastroCategoria();
            frmCategoria.ShowDialog();
        }
    }
}
