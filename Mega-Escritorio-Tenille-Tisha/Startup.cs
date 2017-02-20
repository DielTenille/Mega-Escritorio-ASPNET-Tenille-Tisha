using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mega_Escritorio_Tenille_Tisha.Startup))]
namespace Mega_Escritorio_Tenille_Tisha
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
