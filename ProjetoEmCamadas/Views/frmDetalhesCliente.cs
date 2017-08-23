using Controllers;
using Models;
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
    public partial class frmDetalhesCliente : Form
    {
        public frmDetalhesCliente(int clienteID)
        {
            InitializeComponent();

            ClientesController cliController = new ClientesController();
            Cliente cliente = cliController.Detalhes(clienteID);

            if (cliente != null)
            {
                // Preenchendo a tela com os dados do cliente encontrado
                lblId.Text = cliente.ClienteID.ToString();
                lblNome.Text = cliente.Nome;
                lblCpf.Text = cliente.Cpf;
                this.Show();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado","Erro");
                this.Close();
            }
        }
    }
}
