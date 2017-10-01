using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Epson.MvcWeb.Startup))]
namespace Epson.MvcWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
