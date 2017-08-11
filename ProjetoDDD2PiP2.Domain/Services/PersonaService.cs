using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;

namespace ProjetoDDD2PiP2.Domain.Services
{
    public class PersonaService : ServiceBase<Persona>, IPersonaService
    {
        private readonly IPersonaRepository _personarepository;
        public PersonaService(IPersonaRepository personaRepository) :base(personaRepository)
        {
            _personarepository = personaRepository;
        }

    }
}
