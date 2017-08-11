using AutoMapper;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;

namespace ProjetoDDD2PiP2.MVC.AutoMapper
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
            Mapper.CreateMap<EntidadeViewModel,Entidade>();
            Mapper.CreateMap<PersonaViewModel,Persona>();
            Mapper.CreateMap<SoluctionViewModel,Solutions>();
            Mapper.CreateMap<DeveloperViewModel, Developers>();

        }
    }
}
