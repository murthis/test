using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Visitor_Management.Startup))]
namespace Visitor_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
