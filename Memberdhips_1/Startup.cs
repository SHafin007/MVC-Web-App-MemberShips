using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Memberdhips_1.Startup))]
namespace Memberdhips_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
