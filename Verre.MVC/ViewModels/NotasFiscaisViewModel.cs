
using System;
using System.Collections.Generic;

namespace Verre.MVC.ViewModels
{
    public class NotasFiscaisViewModel
    {
        public int NotaFiscalId { get; set; }
        public int Numero { get; set; }
        public string Chave { get; set; }
        public DateTime DataFaturamento { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}
