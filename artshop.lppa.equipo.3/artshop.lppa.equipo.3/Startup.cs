using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(artshop.lppa.equipo._3.Startup))]
namespace artshop.lppa.equipo._3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
