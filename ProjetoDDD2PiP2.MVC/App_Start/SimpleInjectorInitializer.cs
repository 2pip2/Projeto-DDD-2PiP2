[assembly: WebActivator.PostApplicationStartMethod(typeof(ProjetoDDD2PiP2.MVC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace ProjetoDDD2PiP2.MVC.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Portal.Infra.CrossCutting.IoC;
    using System.Web;
    using Microsoft.Owin;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            InitializeContainer(container);
            container.RegisterPerWebRequest(() => 
            {
                if (HttpContext.Current != null && HttpContext.Current.Items["owin.Enviroment"] == null && container.IsVerifying)
                {
                    return new OwinContext().Authentication;
                }
                return HttpContext.Current.GetOwinContext().Authentication;
             });
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            // For instance:
            BootStrapper.RegisterServices(container);
            //container.Register<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(Lifestyle.Scoped);
            //container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}