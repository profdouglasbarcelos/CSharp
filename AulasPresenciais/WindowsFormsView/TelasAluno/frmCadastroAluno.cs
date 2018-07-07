using Modelos;
using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty; //""
            txtMatricula.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno = new Aluno();

            novoAluno.Nome = txtNome.Text;
            novoAluno.Matricula = int.Parse(txtMatricula.Text);

            AlunosController alunosController = new AlunosController();
            alunosController.Inserir(novoAluno);
        }
    }
}
