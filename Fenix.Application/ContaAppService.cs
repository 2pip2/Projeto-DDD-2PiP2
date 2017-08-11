using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
using Verre.Application.Interface;
namespace Verre.Application
{
    
    public class ContaAppService: AppServiceBase<Conta>, IContaAppService
    {
        private readonly IContaService _contaService;
        public ContaAppService(IContaService contaService):base(contaService)
        {
            _contaService = contaService;

        }
        
    }
}
