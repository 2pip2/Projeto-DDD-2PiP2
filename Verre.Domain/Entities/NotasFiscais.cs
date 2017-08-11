using System;
using System.Collections.Generic;
namespace Verre.Domain.Entities
{
    public class NotasFiscais
    {
        public int NotaFiscalId { get; set; }
        public int Numero { get; set; }
        public string Chave { get; set; }
        public DateTime DataFaturamento { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
