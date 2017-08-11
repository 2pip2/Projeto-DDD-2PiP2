
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;
using Verre.Domain.Interface.Service;

namespace Verre.Domain.Services
{
    public class FabricaService : ServiceBase<Fabrica>, IFabricaService
    {
        private readonly IFabricaRepository _fabricarepository;
        public FabricaService(IFabricaRepository fabricaRepository) :base(fabricaRepository)
        {
            _fabricarepository = fabricaRepository;
        }
        
        
    }
}
