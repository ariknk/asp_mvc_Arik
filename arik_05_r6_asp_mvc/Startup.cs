using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(arik_05_r6_asp_mvc.Startup))]
namespace arik_05_r6_asp_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
