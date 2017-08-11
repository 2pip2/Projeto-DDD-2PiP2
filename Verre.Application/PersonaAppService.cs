#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Interface.Service;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application
{
#pragma warning disable CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Persona' could not be found (are you missing a using directive or an assembly reference?)
    public class PersonaAppService: AppServiceBase<Persona>,IPersonaService
#pragma warning restore CS0246 // The type or namespace name 'Persona' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
        private readonly IPersonaService _personaService;
#pragma warning restore CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
        public PersonaAppService(IPersonaService personaService):base(personaService)
#pragma warning restore CS0246 // The type or namespace name 'IPersonaService' could not be found (are you missing a using directive or an assembly reference?)
        {
            _personaService = personaService;
            
        }
    }
}
