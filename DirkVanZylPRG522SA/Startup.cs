using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirkVanZylPRG522SA.Startup))]
namespace DirkVanZylPRG522SA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
