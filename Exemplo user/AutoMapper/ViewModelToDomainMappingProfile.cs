using AutoMapper;
using ProjetoDDD2PiP2.Domain.Entities;
using Portal2pip2.MVC.ViewModels;

namespace Portal2pip2.MVC.AutoMapper
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
            Mapper.CreateMap<SoluctionViewModel,Soluctions>();
            Mapper.CreateMap<DeveloperViewModel, Developers>();

        }
    }
}
