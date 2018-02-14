using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp2007labs.Startup))]
namespace comp2007labs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
