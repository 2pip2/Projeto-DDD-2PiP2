using Verre.Application.Interface;
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application
{
#pragma warning disable CS0246 // The type or namespace name 'TransformacaoProduto' could not be found (are you missing a using directive or an assembly reference?)
    public class TransformacaoProdutoAppService:AppServiceBase<TransformacaoProduto>,ITransformacaoProdutoService
#pragma warning restore CS0246 // The type or namespace name 'TransformacaoProduto' could not be found (are you missing a using directive or an assembly reference?)
    {
        private readonly ITransformacaoProdutoService _transformacaoprodutoService;
        public TransformacaoProdutoAppService(ITransformacaoProdutoService transformacaoprodutoService):base(transformacaoprodutoService)
        {
            _transformacaoprodutoService = transformacaoprodutoService;
        }
    }
}
