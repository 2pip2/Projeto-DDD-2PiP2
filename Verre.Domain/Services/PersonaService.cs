
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;
using Verre.Domain.Interface.Service;

namespace Verre.Domain.Services
{
    public class PersonaService: ServiceBase<Persona>,IPersonaService
    {
        private readonly IPersonaRepository _personarepository;
        public PersonaService(IPersonaRepository personaRepository):base(personaRepository)
        {
            _personarepository = personaRepository;
        }
        
    }
}
