
using System.Collections.Generic;

namespace Verre.MVC.ViewModels
{
    public class FabricaViewModel
    {
        public int FabricaId { get; set; }
        public IEnumerable<TransformacaoProdutoViewModel> TransformacaoProduto { get; set; }
    }
}
