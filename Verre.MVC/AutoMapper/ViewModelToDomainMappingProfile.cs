using AutoMapper;
using Verre.Domain.Entities;

namespace Verre.MVC.AutoMapper
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
            Mapper.CreateMap<PersonaViewModel,Persona>();
        }
    }
}
