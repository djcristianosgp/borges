namespace borges.View
{
    partial class Movimento
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
            this.PnCabecalho = new System.Windows.Forms.Panel();
            this.dtDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbcMovimento = new System.Windows.Forms.TabControl();
            this.tbpItens = new System.Windows.Forms.TabPage();
            this.tbpPagamento = new System.Windows.Forms.TabPage();
            this.PnCabecalho.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tbcMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnCabecalho
            // 
            this.PnCabecalho.Controls.Add(this.dtDataMovimento);
            this.PnCabecalho.Controls.Add(this.label2);
            this.PnCabecalho.Controls.Add(this.btnBuscarCliente);
            this.PnCabecalho.Controls.Add(this.txtCliente);
            this.PnCabecalho.Controls.Add(this.label1);
            this.PnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.PnCabecalho.Name = "PnCabecalho";
            this.PnCabecalho.Size = new System.Drawing.Size(627, 65);
            this.PnCabecalho.TabIndex = 0;
            // 
            // dtDataMovimento
            // 
            this.dtDataMovimento.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataMovimento.Location = new System.Drawing.Point(286, 28);
            this.dtDataMovimento.Name = "dtDataMovimento";
            this.dtDataMovimento.Size = new System.Drawing.Size(133, 23);
            this.dtDataMovimento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(11, 26);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(40, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(229, 23);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.lblValor);
            this.pnBotoes.Controls.Add(this.lblCusto);
            this.pnBotoes.Controls.Add(this.btnPesquisar);
            this.pnBotoes.Controls.Add(this.btnGravar);
            this.pnBotoes.Controls.Add(this.button1);
            this.pnBotoes.Controls.Add(this.button4);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoes.Location = new System.Drawing.Point(0, 336);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(627, 60);
            this.pnBotoes.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 18);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoEllipsis = true;
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(4, 3);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(38, 15);
            this.lblCusto.TabIndex = 4;
            this.lblCusto.Text = "label3";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPesquisar.Location = new System.Drawing.Point(211, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 60);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGravar.Location = new System.Drawing.Point(315, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(104, 60);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(419, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(523, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nova";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbcMovimento
            // 
            this.tbcMovimento.Controls.Add(this.tbpItens);
            this.tbcMovimento.Controls.Add(this.tbpPagamento);
            this.tbcMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMovimento.Location = new System.Drawing.Point(0, 65);
            this.tbcMovimento.Name = "tbcMovimento";
            this.tbcMovimento.SelectedIndex = 0;
            this.tbcMovimento.Size = new System.Drawing.Size(627, 271);
            this.tbcMovimento.TabIndex = 2;
            // 
            // tbpItens
            // 
            this.tbpItens.Location = new System.Drawing.Point(4, 24);
            this.tbpItens.Name = "tbpItens";
            this.tbpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItens.Size = new System.Drawing.Size(619, 243);
            this.tbpItens.TabIndex = 0;
            this.tbpItens.Text = "Itens";
            this.tbpItens.UseVisualStyleBackColor = true;
            // 
            // tbpPagamento
            // 
            this.tbpPagamento.Location = new System.Drawing.Point(4, 24);
            this.tbpPagamento.Name = "tbpPagamento";
            this.tbpPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPagamento.Size = new System.Drawing.Size(619, 243);
            this.tbpPagamento.TabIndex = 2;
            this.tbpPagamento.Text = "Pagamento";
            this.tbpPagamento.UseVisualStyleBackColor = true;
            // 
            // Movimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 396);
            this.Controls.Add(this.tbcMovimento);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.PnCabecalho);
            this.KeyPreview = true;
            this.Name = "Movimento";
            this.Text = "Movimento";
            this.Load += new System.EventHandler(this.Movimento_Load);
            this.PnCabecalho.ResumeLayout(false);
            this.PnCabecalho.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pnBotoes.PerformLayout();
            this.tbcMovimento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnCabecalho;
        private Label label1;
        private Panel pnBotoes;
        private Button button4;
        private Button btnGravar;
        private Button button1;
        private TabControl tbcMovimento;
        private TabPage tbpItens;
        private TabPage tbpPagamento;
        private Button btnBuscarCliente;
        private TextBox txtCliente;
        private Label label2;
        private Button btnPesquisar;
        private DateTimePicker dtDataMovimento;
        private Label lblValor;
        private Label lblCusto;
    }
}