using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fakebook.Startup))]
namespace Fakebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
