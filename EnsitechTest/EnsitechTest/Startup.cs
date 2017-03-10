using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnsitechTest.Startup))]
namespace EnsitechTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
