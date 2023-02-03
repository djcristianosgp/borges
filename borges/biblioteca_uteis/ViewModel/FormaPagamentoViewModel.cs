using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_uteis.ViewModel
{
    public class FormaPagamentoViewModel
    {
        public Guid GuidFormaPagamento { get; set;}
        public string DescricaoPagamento { get; set;}
        public bool Ativo { get; set; } = true;
        public bool APrazo { get; set; } = false;
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
