using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LyfOn.Startup))]
namespace LyfOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
