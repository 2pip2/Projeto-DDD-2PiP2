using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Service;

namespace ProjetoDDD2PiP2.Application
{
    
    public class DeveloperAppService: AppServiceBase<Developers>, IDeveloperAppService
    {
        private readonly IDeveloperService _developerService;
        public DeveloperAppService(IDeveloperService developerService):base(developerService)
        {
            _developerService = developerService;
        }
        
    }
}
