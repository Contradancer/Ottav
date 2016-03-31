using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ottav.Startup))]
namespace Ottav
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
