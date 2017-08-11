using Verre.Application.Interface;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;

namespace Verre.Application
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
