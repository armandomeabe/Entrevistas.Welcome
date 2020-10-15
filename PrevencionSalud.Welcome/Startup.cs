using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrevencionSalud.Welcome.Startup))]
namespace PrevencionSalud.Welcome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
