using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ProjetoDDD2PiP2.MVC.AutoMapper;
using System.Web;

namespace ProjetoDDD2PiP2.MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
