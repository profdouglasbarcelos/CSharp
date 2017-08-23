using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1003_WF2
{
    public partial class ucEndereco : UserControl
    {
        public ucEndereco()
        {
            InitializeComponent();
        }

        public String nomeRua
        {
            get { return txtRua.Text; }
            set { txtRua.Text = value; }
        }
    }
}
