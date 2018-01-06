using Microsoft.Owin;
using Owin;
using WebIdentity.Domain;

[assembly: OwinStartupAttribute(typeof(WebIdentity.Startup))]
namespace WebIdentity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           app.ConfigureAuth();
        }
    }
}
