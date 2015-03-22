using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOpniao.Presentation.Startup))]
namespace IOpniao.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
