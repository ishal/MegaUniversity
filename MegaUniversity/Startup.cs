using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaUniversity.Startup))]
namespace MegaUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
