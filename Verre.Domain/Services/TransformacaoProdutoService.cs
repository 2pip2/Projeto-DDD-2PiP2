using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
using Verre.Domain.Interface.Repositories;
using System;
using System.Collections.Generic;

namespace Verre.Domain.Services
{
    public class TransformacaoProdutoService : ServiceBase<TransformacaoProdutoService>, ITransformacaoProdutoService
    {
        private readonly ITransformacaoProdutoRepository _transformacaoProdutoServicerepository;
        public TransformacaoProdutoService(ITransformacaoProdutoRepository transformacaoProdutoRepository) :base(transformacaoProdutoRepository)
        {
            _transformacaoProdutoServicerepository = transformacaoProdutoRepository;
        }

        void IServiceBase<TransformacaoProduto>.Add(TransformacaoProduto obj)
        {
            throw new NotImplementedException();
        }

        void IServiceBase<TransformacaoProduto>.Dispose()
        {
            throw new NotImplementedException();
        }

        IEnumerable<TransformacaoProduto> IServiceBase<TransformacaoProduto>.GetAll()
        {
            throw new NotImplementedException();
        }

        TransformacaoProduto IServiceBase<TransformacaoProduto>.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        void IServiceBase<TransformacaoProduto>.Remove(TransformacaoProduto obj)
        {
            throw new NotImplementedException();
        }

        void IServiceBase<TransformacaoProduto>.Update(TransformacaoProduto obj)
        {
            throw new NotImplementedException();
        }
    }
}
