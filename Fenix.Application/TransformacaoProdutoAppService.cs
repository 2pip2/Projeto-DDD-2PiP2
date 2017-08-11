using Verre.Application.Interface;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;

namespace Verre.Application
{
    public class TransformacaoProdutoAppService:AppServiceBase<TransformacaoProduto>,ITransformacaoProdutoAppService
    {
        private readonly ITransformacaoProdutoService _transformacaoprodutoService;
        public TransformacaoProdutoAppService(ITransformacaoProdutoService transformacaoprodutoService):base(transformacaoprodutoService)
        {
            _transformacaoprodutoService = transformacaoprodutoService;
        }
    }
}
