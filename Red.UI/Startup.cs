using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Red.UI.Startup))]
namespace Red.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
