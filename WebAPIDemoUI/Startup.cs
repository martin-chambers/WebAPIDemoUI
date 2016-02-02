using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPIDemoUI.Startup))]
namespace WebAPIDemoUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
