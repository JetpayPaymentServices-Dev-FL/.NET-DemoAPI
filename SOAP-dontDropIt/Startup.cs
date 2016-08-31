using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOAP_dontDropIt.Startup))]
namespace SOAP_dontDropIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
