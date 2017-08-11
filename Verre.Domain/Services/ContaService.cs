
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;
using Verre.Domain.Interface.Service;

namespace Verre.Domain.Services
{
    public class ContaService: ServiceBase<Conta>,IContaService
    {
        private readonly IContaRepository _contarepository;
        public ContaService(IContaRepository contaRepository) :base(contaRepository)
        {
            _contarepository = contaRepository;
        }
        
        
    }
}
