using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dnm.Startup))]
namespace dnm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
