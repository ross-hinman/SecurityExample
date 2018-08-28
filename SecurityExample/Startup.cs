using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityExample.Startup))]
namespace SecurityExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
