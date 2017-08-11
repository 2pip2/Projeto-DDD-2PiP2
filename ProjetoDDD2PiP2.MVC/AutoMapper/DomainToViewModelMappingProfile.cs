using AutoMapper;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.MVC.ViewModels;

namespace ProjetoDDD2PiP2.MVC.AutoMapper
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
            Mapper.CreateMap<Solutions,SoluctionViewModel>();
            Mapper.CreateMap<Developers, DeveloperViewModel>();
        }
    }
}
