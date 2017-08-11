#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application.Interface
{
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
    public interface IProdutoAppService : IAppServiceBase<Produto>
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
    {
    }
}
