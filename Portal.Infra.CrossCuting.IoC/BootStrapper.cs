using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Portal.Infra.CrossCutting.Identity.Configuration;
using Portal.Infra.CrossCutting.Identity.Context;
using Portal.Infra.CrossCutting.Identity.Model;
using ProjetoDDD2PiP2.Application;
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using ProjetoDDD2PiP2.Domain.Services;
using ProjetoDDD2PiP2.Infra.Data.Repositories;
using SimpleInjector;

namespace Portal.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //EF
            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => 
                new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();
            //outros
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            //Developer
            container.Register<IDeveloperAppService, DeveloperAppService>(Lifestyle.Scoped);
            container.Register<IDeveloperService, DeveloperService>(Lifestyle.Scoped);
            container.Register<IDevelopersRepository, DevelopersRepository>(Lifestyle.Scoped);
            //Entidade
            container.Register<IEntidadeAppService, EntidadeAppService>(Lifestyle.Scoped);
            container.Register<IEntidadeService, EntidadeService>(Lifestyle.Scoped);
            container.Register<IEntidadeRepository, EntidadeRepository>(Lifestyle.Scoped);
            //Persona
            container.Register<IPersonaAppService, PersonaAppService>(Lifestyle.Scoped);
            container.Register<IPersonaService, PersonaService>(Lifestyle.Scoped);
            container.Register<IPersonaRepository, PersonaRepository>(Lifestyle.Scoped);
            //Soluction
            container.Register<ISoluctionAppService, SoluctionAppService>(Lifestyle.Scoped);
            container.Register<ISoluctionService, SoluctionService>(Lifestyle.Scoped);
            container.Register<ISoluctionRepository, SoluctionRepository>(Lifestyle.Scoped);
            

            //            container.Register<IPersonaRepository, PersonaRepository>();
            //container.Register<IDeveloperAppService, DeveloperAppService>();
            //kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            //kernel.Bind<IDeveloperAppService>().To<DeveloperAppService>();
        }
    }
}