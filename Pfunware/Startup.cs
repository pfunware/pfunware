using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pfunware.Startup))]
namespace Pfunware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
