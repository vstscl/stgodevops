using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StgoDevOps.Startup))]
namespace StgoDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
