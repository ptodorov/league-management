using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenHouse.Web.Startup))]
namespace OpenHouse.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
