using System;
using System.Collections.Generic;
using Verre.Application.Interface;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
namespace Verre.Application
{
    public class ProdutoAppService:AppServiceBase<Produto>,IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IProdutoService produtoService):base(produtoService)
        {
            _produtoService = produtoService;
        }
        
    }

}
