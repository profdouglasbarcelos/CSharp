using Controllers2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Relatorios.Alunos;

namespace Views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
            rvRelatorios.ProcessingMode = 
                Microsoft.Reporting.WinForms.ProcessingMode.Local;

            // 3.1) Definir report
            rvRelatorios.LocalReport.ReportPath = 
                @"Alunos\rptAnalitico.rdlc";


            rvRelatorios.LocalReport.DataSources.Clear();

            // 3.2 Fazer consulta
            var listaAlunos = AlunosController.ListarTodos();

            dsAlunosAnalitico dataSet = new dsAlunosAnalitico();


            foreach (Aluno aluno in listaAlunos)
            {
                dataSet.dtAlunos.AdddtAlunosRow(
                    aluno.AlunoID.ToString(),
                    aluno.Nome,
                    aluno.Cpf
                    );
            }

            // 3.3 Apontar Dataset
            rvRelatorios.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "dsAlunos", 
                    (DataTable)dataSet.dtAlunos)
                );

            this.rvRelatorios.RefreshReport();
        }
    }
}
