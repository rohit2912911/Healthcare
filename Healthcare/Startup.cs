using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Healthcare.Startup))]
namespace Healthcare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
