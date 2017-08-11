using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verre.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Fatura(NotasFiscais n) {
            if (n == null) { return false; } else { return true; }
        }

        public IEnumerable<TransformacaoProduto> TransformacaoProduto { get; set; }

    }
}
