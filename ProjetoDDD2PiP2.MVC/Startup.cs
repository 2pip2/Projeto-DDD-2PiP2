using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoDDD2PiP2.MVC.Startup))]
namespace ProjetoDDD2PiP2.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuth(app);
        }
        
    }
}
