using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisitorManagement.Startup))]
namespace VisitorManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
