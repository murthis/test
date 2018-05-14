using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressManagementUserBook.Startup))]
namespace AddressManagementUserBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
