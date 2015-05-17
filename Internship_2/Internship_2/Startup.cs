using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internship_2.Startup))]
namespace Internship_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
