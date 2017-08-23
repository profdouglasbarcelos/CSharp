using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class frmCadastroCliente : Form
    {
        public int? ClienteID { get; set; }
        public Cliente _Cliente { get; set; }

        public frmCadastroCliente(int? idCliente)
        {
            InitializeComponent();

            if (idCliente.HasValue)
                ClienteID = idCliente;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarFormulario();

        }

        private void CarregarFormulario()
        {
            if (ClienteID.HasValue)
            {
                ClientesController cliController = new ClientesController();
                _Cliente = cliController.Detalhes(ClienteID.Value);

                if (_Cliente != null)
                {
                    txtNome.Text = _Cliente.Nome;
                    txtCpf.Text = _Cliente.Cpf;
                    btnSalvar.Text = "Atualizar";
                }
            }
            else
                LimparCampos();
        }

        public void LimparCampos()
        {
            ClienteID = null;
            _Cliente = null;
            txtNome.Clear();
            txtCpf.Clear();
            btnSalvar.Text = "Salvar";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (ClienteID.HasValue)
                    {
                        ClientesController cliController = new ClientesController();
                        cliController.Editar(ClienteID.Value, txtNome.Text, txtCpf.Text);

                        MessageBox.Show("Cliente alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        ClientesController cliController = new ClientesController();
                        cliController.Adicionar(txtNome.Text, txtCpf.Text);

                        MessageBox.Show("Cliente cadastrado com sucesso");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private bool Validar()
        {
            return !(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCpf.Text));
        }
    }
}
