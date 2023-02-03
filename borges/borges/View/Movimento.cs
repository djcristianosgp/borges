using biblioteca_uteis.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borges.View
{
    public partial class Movimento : Form
    {
        public Movimento()
        {
            InitializeComponent();
        }

        public string sCusto = "Custo: R${0}";
        public string sValor = "Valor: R${0}";

        public MovimentoViewModel mMovimento = new MovimentoViewModel();
        public MovimentoItensViewModel mMovimentoItens = new MovimentoItensViewModel();
        public ClienteViewModel cCliente= new ClienteViewModel();
        public FormaPagamentoViewModel fFormaPagemento = new FormaPagamentoViewModel();

        private void Movimento_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        public void Inicializa()
        {
            lblCusto.Text = String.Format(sCusto,"0,00");
            lblValor.Text = String.Format(sValor,"0,00");
        }

        public void CalculaValores()
        {

        }

        public void PesquisaVenda()
        {

        }

        public void PesquisaCliente(TextBox textBox)
        {

        }

        public void PesquisaItem()
        {

        }

        public void PesquisaFormaPagemento()
        {

        }

        public bool ValidaFechar()
        {
            return false;
        }

        public bool ValidaGravar()
        {
            return true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente(txtCliente);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaVenda();
        }             

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (ValidaGravar())
            {

            }
            else
            {
                MessageBox.Show("Algums informações estão incompletas para finalizar a venda!!\r\n" +
                    "Por Favor, verifique todas as informações antes de continuar!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
