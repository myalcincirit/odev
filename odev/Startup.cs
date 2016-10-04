using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mertyalcincirit.Startup))]
namespace mertyalcincirit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
