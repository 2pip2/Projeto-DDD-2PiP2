using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portal_2pip2.MVC.Startup))]
namespace Portal_2pip2.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
