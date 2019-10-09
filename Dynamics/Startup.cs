using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dynamics.Startup))]
namespace Dynamics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
