using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson5.Startup))]
namespace lesson5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
