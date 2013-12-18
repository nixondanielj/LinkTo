using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkTo.Startup))]
namespace LinkTo
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
