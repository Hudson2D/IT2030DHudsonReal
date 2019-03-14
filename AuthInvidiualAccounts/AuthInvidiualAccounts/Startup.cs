using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthInvidiualAccounts.Startup))]
namespace AuthInvidiualAccounts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
