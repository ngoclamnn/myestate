using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEsate.Startup))]
namespace MyEsate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
