using AutoMapper;
using Verre.Domain.Entities;
using Verre.WebAPI.ApiModels;

namespace Verre.WebAPI.AutoMapper
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
            Mapper.CreateMap<Persona,PersonaModelApi>();            
        }
    }
}
