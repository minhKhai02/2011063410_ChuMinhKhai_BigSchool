using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011063410_ChuMinhKhai.Startup))]
namespace _2011063410_ChuMinhKhai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
