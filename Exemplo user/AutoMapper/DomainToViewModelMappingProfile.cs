using AutoMapper;
using ProjetoDDD2PiP2.Domain.Entities;
using Portal2pip2.MVC.ViewModels;

namespace Portal2pip2.MVC.AutoMapper
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
            Mapper.CreateMap<Entidade,EntidadeViewModel>();
            Mapper.CreateMap<Persona,PersonaViewModel>();
            Mapper.CreateMap<Soluctions,SoluctionViewModel>();
            Mapper.CreateMap<Developers, DeveloperViewModel>();
        }
    }
}
