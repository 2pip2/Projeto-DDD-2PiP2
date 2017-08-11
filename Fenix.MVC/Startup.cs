using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fenix.MVC.Startup))]
namespace Fenix.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
