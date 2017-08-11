using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsuarioSenha.Startup))]
namespace UsuarioSenha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
