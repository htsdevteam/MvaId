using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ch0201.Startup))]
namespace Ch0201
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
