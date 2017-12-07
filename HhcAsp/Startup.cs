using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HhcAsp.Startup))]
namespace HhcAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
