using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgileLizard.Site.Startup))]
namespace AgileLizard.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
