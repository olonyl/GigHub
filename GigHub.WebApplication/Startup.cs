using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub.WebApplication.Startup))]
namespace GigHub.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
