using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymClass.Startup))]
namespace GymClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
