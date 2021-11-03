using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESS.MVC.Startup))]
namespace RESS.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
