using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AAUInwardOutward.Startup))]
namespace AAUInwardOutward
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
