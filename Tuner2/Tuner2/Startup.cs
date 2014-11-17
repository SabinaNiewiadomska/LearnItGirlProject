using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuner2.Startup))]
namespace Tuner2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
