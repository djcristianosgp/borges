using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borges.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mniCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente CadCliente= new CadastroCliente();
            CadCliente.MdiParent = this;
            CadCliente.Show();
        }
    }
}
