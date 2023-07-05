using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PontoWeb.Startup))]
namespace PontoWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
