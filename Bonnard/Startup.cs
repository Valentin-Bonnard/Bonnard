using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bonnard.Startup))]
namespace Bonnard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
