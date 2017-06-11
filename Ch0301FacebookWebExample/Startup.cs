using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ch0301FacebookWebExample.Startup))]
namespace Ch0301FacebookWebExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
