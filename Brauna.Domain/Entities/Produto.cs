using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brauna.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int CategoriaProdutoId { get; set; }
        public virtual Categoria_Produto Categoria_Produto { get; set; }
        public bool Criacao { get; set; }
        public bool Modelagem { get; set; }
        public bool Piloto { get; set; }


    }
}
