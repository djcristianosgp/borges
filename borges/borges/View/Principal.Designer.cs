namespace borges.View
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEndereco = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroMunicipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDocumentoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroServico = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMovimentoDeVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniCadastroFormaPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuEndereco,
            this.mnuCliente,
            this.mnuServico,
            this.mnuProduto,
            this.mnuMovimento,
            this.mnuBackup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnPrincipal";
            // 
            // mnuCliente
            // 
            this.mnuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroCliente,
            this.mniDocumentoCliente});
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(56, 20);
            this.mnuCliente.Text = "Cliente";
            // 
            // mnuEndereco
            // 
            this.mnuEndereco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroMunicipo});
            this.mnuEndereco.Name = "mnuEndereco";
            this.mnuEndereco.Size = new System.Drawing.Size(68, 20);
            this.mnuEndereco.Text = "Endereço";
            // 
            // mnuServico
            // 
            this.mnuServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroServico});
            this.mnuServico.Name = "mnuServico";
            this.mnuServico.Size = new System.Drawing.Size(57, 20);
            this.mnuServico.Text = "Serviço";
            // 
            // mnuProduto
            // 
            this.mnuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroProduto});
            this.mnuProduto.Name = "mnuProduto";
            this.mnuProduto.Size = new System.Drawing.Size(62, 20);
            this.mnuProduto.Text = "Produto";
            // 
            // mnuMovimento
            // 
            this.mnuMovimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroFormaPagamento,
            this.toolStripSeparator1,
            this.mniMovimentoDeVenda});
            this.mnuMovimento.Name = "mnuMovimento";
            this.mnuMovimento.Size = new System.Drawing.Size(81, 20);
            this.mnuMovimento.Text = "Movimento";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mnuBackup
            // 
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(58, 20);
            this.mnuBackup.Text = "Backup";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniConfiguracoes});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mniCadastroMunicipo
            // 
            this.mniCadastroMunicipo.Name = "mniCadastroMunicipo";
            this.mniCadastroMunicipo.Size = new System.Drawing.Size(194, 22);
            this.mniCadastroMunicipo.Text = "Cadastro de Municipio";
            // 
            // mniCadastroCliente
            // 
            this.mniCadastroCliente.Name = "mniCadastroCliente";
            this.mniCadastroCliente.Size = new System.Drawing.Size(193, 22);
            this.mniCadastroCliente.Text = "Cadastro de Cliente";
            this.mniCadastroCliente.Click += new System.EventHandler(this.mniCadastroCliente_Click);
            // 
            // mniDocumentoCliente
            // 
            this.mniDocumentoCliente.Name = "mniDocumentoCliente";
            this.mniDocumentoCliente.Size = new System.Drawing.Size(193, 22);
            this.mniDocumentoCliente.Text = "Documento de Cliente";
            // 
            // mniCadastroServico
            // 
            this.mniCadastroServico.Name = "mniCadastroServico";
            this.mniCadastroServico.Size = new System.Drawing.Size(180, 22);
            this.mniCadastroServico.Text = "Cadastro de Serviço";
            // 
            // mniCadastroProduto
            // 
            this.mniCadastroProduto.Name = "mniCadastroProduto";
            this.mniCadastroProduto.Size = new System.Drawing.Size(183, 22);
            this.mniCadastroProduto.Text = "Cadastro de Produto";
            // 
            // mniMovimentoDeVenda
            // 
            this.mniMovimentoDeVenda.Name = "mniMovimentoDeVenda";
            this.mniMovimentoDeVenda.Size = new System.Drawing.Size(254, 22);
            this.mniMovimentoDeVenda.Text = "Movimento de Vendas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // mniCadastroFormaPagamento
            // 
            this.mniCadastroFormaPagamento.Name = "mniCadastroFormaPagamento";
            this.mniCadastroFormaPagamento.Size = new System.Drawing.Size(254, 22);
            this.mniCadastroFormaPagamento.Text = "Cadastro de Forma de Pagamento";
            // 
            // mniConfiguracoes
            // 
            this.mniConfiguracoes.Name = "mniConfiguracoes";
            this.mniConfiguracoes.Size = new System.Drawing.Size(180, 22);
            this.mniConfiguracoes.Text = "Configurações";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 365);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCliente;
        private ToolStripMenuItem mnuEndereco;
        private ToolStripMenuItem mnuServico;
        private ToolStripMenuItem mnuProduto;
        private ToolStripMenuItem mnuMovimento;
        private ToolStripMenuItem mnuBackup;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mniConfiguracoes;
        private ToolStripMenuItem mniCadastroMunicipo;
        private ToolStripMenuItem mniCadastroCliente;
        private ToolStripMenuItem mniDocumentoCliente;
        private ToolStripMenuItem mniCadastroServico;
        private ToolStripMenuItem mniCadastroProduto;
        private ToolStripMenuItem mniCadastroFormaPagamento;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mniMovimentoDeVenda;
    }
}