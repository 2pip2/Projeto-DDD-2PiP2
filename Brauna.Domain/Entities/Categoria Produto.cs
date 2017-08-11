using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brauna.Domain.Entities
{
    public class Categoria_Produto
    {
        public int CategoriaProdutoId { get; set; }
        public string Nome { get; set; }
        public bool ProdutoVenda { get; set; }
        public IEnumerable<Produto> Produto { get; set; }

    }
}
