using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_02.Startup))]
namespace Lab_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
