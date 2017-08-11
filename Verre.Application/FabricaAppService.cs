using Verre.Application.Interface;
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Interface.Service;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application
{
#pragma warning disable CS0246 // The type or namespace name 'Fabrica' could not be found (are you missing a using directive or an assembly reference?)
    public class FabricaAppService:AppServiceBase<Fabrica>,IFabricaAppService
#pragma warning restore CS0246 // The type or namespace name 'Fabrica' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0246 // The type or namespace name 'IFabricaService' could not be found (are you missing a using directive or an assembly reference?)
        private readonly IFabricaService _fabricaService;
#pragma warning restore CS0246 // The type or namespace name 'IFabricaService' could not be found (are you missing a using directive or an assembly reference?)

#pragma warning disable CS0246 // The type or namespace name 'IFabricaService' could not be found (are you missing a using directive or an assembly reference?)
        public FabricaAppService(IFabricaService fabricaService ):base(fabricaService)
#pragma warning restore CS0246 // The type or namespace name 'IFabricaService' could not be found (are you missing a using directive or an assembly reference?)
        {
            _fabricaService = fabricaService;

        }
        }

}
