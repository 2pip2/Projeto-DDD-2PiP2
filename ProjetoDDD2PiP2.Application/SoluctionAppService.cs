
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Service;

namespace ProjetoDDD2PiP2.Application
{
    
    public class SoluctionAppService: AppServiceBase<Solutions>, ISoluctionAppService
    {
        private readonly ISoluctionService _soluctionService;
        public SoluctionAppService(ISoluctionService soluctionService):base(soluctionService)
        {
            _soluctionService = soluctionService;
        }
        
    }
}
