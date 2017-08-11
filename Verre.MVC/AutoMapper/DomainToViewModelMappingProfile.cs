using AutoMapper;
using Verre.Domain.Entities;

namespace Verre.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public override string ProfileName
        {
            get {
                return "ViewModelToDomainMappings";
            }
        }
        protected  override void Configure()
        {
            Mapper.CreateMap<Persona,PersonaViewModel>();
         
        }
    }
}
