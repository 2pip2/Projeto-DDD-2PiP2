
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Services
{
    public class DeveloperService: ServiceBase<Developers>,IDeveloperService
    {
        private readonly IDevelopersRepository _developersrepository;
        public DeveloperService(IDevelopersRepository developersRepository) :base(developersRepository)
        {
            _developersrepository = developersRepository;
        }
        
        
    }
}
