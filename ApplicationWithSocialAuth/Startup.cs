using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationWithSocialAuth.Startup))]
namespace ApplicationWithSocialAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
