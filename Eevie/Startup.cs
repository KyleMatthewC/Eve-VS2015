using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eevie.Startup))]
namespace Eevie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
