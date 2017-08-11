using Verre.Application.Interface;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
namespace Verre.Application
{
    public class NotasFiscaisAppService:AppServiceBase<NotasFiscais>,INotasFiscaisAppService
    {
        private readonly INotasFiscaisService _notaficaisService;
        public NotasFiscaisAppService(INotasFiscaisService notaficaisService) : base(notaficaisService)
        {
            _notaficaisService = notaficaisService;
        }
    }
}
