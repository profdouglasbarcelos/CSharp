using Aula1003_Camadas.Views;
using System;
using System.Windows.Forms;

namespace Aula1003_Camadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastroCarro_Click(object sender, EventArgs e)
        {
            frmCadastroCarro cadCarro = new frmCadastroCarro();
            cadCarro.ShowDialog();
        }
    }
}
