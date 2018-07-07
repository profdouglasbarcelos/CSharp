using System.Windows.Forms;

namespace WindowsFormsView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCancelar.Text = "Abrir Form2";
            btnSalvar.Text = "Ok";
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            btnCancelar.Enabled = true;
        }
    }
}
