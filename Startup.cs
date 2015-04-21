using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATLAS.Startup))]
namespace ATLAS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
