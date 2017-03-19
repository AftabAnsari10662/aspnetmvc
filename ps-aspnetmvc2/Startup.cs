using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ps_aspnetmvc2.Startup))]
namespace ps_aspnetmvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
