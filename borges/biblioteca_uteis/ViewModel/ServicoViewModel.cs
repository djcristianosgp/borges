using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_uteis.ViewModel
{
    public class ServicoViewModel
    {
        public Guid GuidServico { get; set; }
        public string Servico { get; set; }
        public bool Ativo { get; set; } = true;
        public string Tipo { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
