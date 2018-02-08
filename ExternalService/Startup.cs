using Autofac;
using Autofac.Integration.WebApi;
using ExternalService.Clients;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(ExternalService.Startup))]

namespace ExternalService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            var container = Register();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            WebApiConfig.Register(config);

            app.UseWebApi(config);
        }

        private IContainer Register()
        {
            var builder = new ContainerBuilder();

            // register types in the corresponding module Api / Core not directly here            
            builder.RegisterType<YelpRestApiClient>().As<IYelpRestApiClient>();

            //builder.RegisterType<ILogHelper>().As<LogHelper>();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            return builder.Build();
        }
    }
}
