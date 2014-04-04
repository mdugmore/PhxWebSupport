using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupportWebApplication.Startup))]
namespace SupportWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
