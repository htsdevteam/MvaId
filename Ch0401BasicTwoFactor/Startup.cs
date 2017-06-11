using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ch0401BasicTwoFactor.Startup))]
namespace Ch0401BasicTwoFactor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
