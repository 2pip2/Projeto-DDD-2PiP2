
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System.Collections.Generic;
using System;

namespace ProjetoDDD2PiP2.Domain.Services
{
    public class SoluctionService: ServiceBase<Solutions>,ISoluctionService
    {
        private readonly ISoluctionRepository _soluctionrepository;
        public SoluctionService(ISoluctionRepository soluctionRepository) :base(soluctionRepository)
        {
            _soluctionrepository = soluctionRepository;
        }
        
    }
}
