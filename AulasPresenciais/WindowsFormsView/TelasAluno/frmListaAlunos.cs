using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmListaAlunos : Form
    {
        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            // preencher a lista ao carregar a tela (LOAD)
            AlunosController alunosController = new AlunosController();
            dgvAlunos.DataSource = alunosController.ListarTodos();
        }
    }
}
