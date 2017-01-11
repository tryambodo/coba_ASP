using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coba_coba.Startup))]
namespace coba_coba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
