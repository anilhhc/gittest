using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HhcBetaTest.Startup))]
namespace HhcBetaTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
