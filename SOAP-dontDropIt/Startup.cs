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
       
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy("AllowSpecificOrigin",
        //            builder => builder.WithOrigins("http://api.randomuser.me/"));
        //        options.AddPolicy("AllowAllMethods",
        //            builder =>
        //            {
        //                builder.WithOrigins("http://api.randomuser.me/")
        //                       .AllowAnyMethod();
        //            });
        //        options.AddPolicy("AllowAllHeaders",
        //            builder =>
        //            {
        //                builder.WithOrigins("http://api.randomuser.me/")
        //                       .AllowAnyHeader();
        //            });
        //        options.AddPolicy("AllowCredentials",
        //            builder =>
        //            {
        //                builder.WithOrigins("http://api.randomuser.me/")
        //                       .AllowCredentials();
        //            });
        //    });

        //}
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
