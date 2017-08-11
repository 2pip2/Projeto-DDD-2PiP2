
using System.Collections.Generic;

namespace Verre.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Fatura { get; set; }
        public IEnumerable<TransformacaoProdutoViewModel> TransformacaoProduto { get; set; }

    }
}
