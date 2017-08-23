using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1003_WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFilhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilho f = new frmFilho();
            f.MdiParent = this;
            f.Show();
        }
    }
}
