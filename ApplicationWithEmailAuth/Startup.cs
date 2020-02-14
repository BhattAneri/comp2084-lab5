using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationWithEmailAuth.Startup))]
namespace ApplicationWithEmailAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
