#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Interface.Service;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Application.Interface;
namespace Verre.Application
{
    
#pragma warning disable CS0246 // The type or namespace name 'Conta' could not be found (are you missing a using directive or an assembly reference?)
    public class ContaAppService: AppServiceBase<Conta>, IContaAppService
#pragma warning restore CS0246 // The type or namespace name 'Conta' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0246 // The type or namespace name 'IContaService' could not be found (are you missing a using directive or an assembly reference?)
        private readonly IContaService _contaService;
#pragma warning restore CS0246 // The type or namespace name 'IContaService' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'IContaService' could not be found (are you missing a using directive or an assembly reference?)
        public ContaAppService(IContaService contaService):base(contaService)
#pragma warning restore CS0246 // The type or namespace name 'IContaService' could not be found (are you missing a using directive or an assembly reference?)
        {
            _contaService = contaService;

        }
        
    }
}
