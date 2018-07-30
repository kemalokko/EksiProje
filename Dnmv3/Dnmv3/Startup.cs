using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dnmv3.Startup))]
namespace Dnmv3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
