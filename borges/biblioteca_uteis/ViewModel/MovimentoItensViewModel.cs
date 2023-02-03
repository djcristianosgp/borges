using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_uteis.ViewModel
{
    public class MovimentoItensViewModel
    {
        public Guid ID { get; set; }
        public string GuidMovimento { get; set; }
        public string GuidCliente { get; set; }
        public string GuidServico { get; set; }
        public string GuidProduto { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }//produto ou serviço
        public string Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
