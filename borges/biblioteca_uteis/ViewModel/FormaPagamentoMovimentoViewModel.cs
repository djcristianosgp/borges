using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_uteis.ViewModel
{
    public class FormaPagamentoMovimentoViewModel
    {
        public Guid GuidMovimentoPagamento { get; set; }
        public string GuidFormaPagamento { get; set; }
        public string GuidMovimento { get; set; }
        public decimal ValorFormaPagamento { get; set; }
        public int Parcelas { get; set; } = 0;
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
