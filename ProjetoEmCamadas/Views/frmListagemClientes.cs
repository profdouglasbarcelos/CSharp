using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmListagemClientes : Form
    {
        public frmListagemClientes()
        {
            InitializeComponent();
        }

        private void frmListagemClientes_Load(object sender, EventArgs e)
        {
            CarregarGridViewClientes();
        }

        private void CarregarGridViewClientes()
        {
            dgvClientes.DataSource = null;
            ClientesController cliController = new ClientesController();
            dgvClientes.DataSource = cliController.Listar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);
                //frmDetalhesCliente telaDetalhes = new frmDetalhesCliente(idSelecionado);

                frmCadastroCliente cadCliente = new frmCadastroCliente(idSelecionado);
                //cadCliente.MdiParent = this;
                cadCliente.ShowDialog();

                CarregarGridViewClientes();
            }

        }
    }
}
