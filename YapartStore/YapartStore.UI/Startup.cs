using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YapartStore.UI.Startup))]
namespace YapartStore.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
