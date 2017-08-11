
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;
using Verre.Domain.Interface.Service;

namespace Verre.Domain.Services
{
    public class NotasFicaisService: ServiceBase<NotasFiscais>, INotasFiscaisService
    {
        private readonly INotasFiscaisRepository _nfrepository;
        public NotasFicaisService(INotasFiscaisRepository notafiscalRepository) :base(notafiscalRepository)
        {
            _nfrepository = notafiscalRepository;
        }
        
        
    }
}
