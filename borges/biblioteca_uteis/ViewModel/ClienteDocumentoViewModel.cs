namespace biblioteca_uteis.ViewModel
{
    public class ClienteDocumentoViewModel
    {
        public Guid Id { get; set; }
        public string Cliente { get; set; }
        public string Movimento { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorRestante { get; set; }
        public bool DocumentoFechado { get; set; } = true;
        public bool DocumentoExcluido { get; set; } = false;        
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
