using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Service;

namespace ProjetoDDD2PiP2.Application
{
    
    public class PersonaAppService: AppServiceBase<Persona>,IPersonaAppService
    {
        private readonly IPersonaService _personaService;

        
        public PersonaAppService(IPersonaService personaService):base(personaService)
        {
            _personaService = personaService;
        }
    }
}
