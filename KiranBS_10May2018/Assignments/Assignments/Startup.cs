using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignments.Startup))]
namespace Assignments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
