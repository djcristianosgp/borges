using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_uteis.ViewModel
{
    public class MovimentoViewModel
    {
        public Guid GuidMovimento { get; set; }
        public string GuidCliente { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal CustoMovimento { get; set; }
        public decimal ValorMovimento { get; set; }        
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
