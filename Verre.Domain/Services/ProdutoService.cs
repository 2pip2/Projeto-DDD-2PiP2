
using System.Collections.Generic;
using System;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
using Verre.Domain.Interface.Repositories;

namespace Verre.Domain.Services
{
    public class ProdutoService: ServiceBase<Produto>,IProdutoService
    {
        private readonly IProdutoRepository _produtorepository;
        public ProdutoService(IProdutoRepository produtoRepository) :base(produtoRepository)
        {
            _produtorepository = produtoRepository;
        }
        
    }
}
