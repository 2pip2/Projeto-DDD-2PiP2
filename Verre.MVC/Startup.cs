using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Verre.MVC.Startup))]
namespace Verre.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuth(app);
        }       
    }
}
