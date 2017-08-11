using AutoMapper;
using Verre.Domain.Entities;
using Verre.WebAPI.ApiModels;

namespace Verre.WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<PersonaModelApi,Persona>();
        }
    }
}
