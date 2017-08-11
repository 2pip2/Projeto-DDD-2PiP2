using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verre.MVC.ViewModels
{
    public class EncomendasViewModel
    {
        public int EncomendaId { get; set; }
        public int NumeroEncomenda { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime  DataPrevisaoEntrega { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
        
    }
}
