using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DerbyCityDevelopment.Startup))]
namespace DerbyCityDevelopment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
