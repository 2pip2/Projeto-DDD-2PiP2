using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verre.Domain.Entities
{
    public class Fabrica
    {
        public int FabricaId { get; set; }
        public IEnumerable<TransformacaoProduto> TransformacaoProduto { get; set; }
    }
}
