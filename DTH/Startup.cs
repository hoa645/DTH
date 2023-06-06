using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DTH.Startup))]
namespace DTH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
