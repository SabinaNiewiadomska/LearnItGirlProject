using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuner.Startup))]
namespace Tuner
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
