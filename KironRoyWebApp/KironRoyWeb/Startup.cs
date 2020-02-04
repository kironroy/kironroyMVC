using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KironRoyWeb.Startup))]
namespace KironRoyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
