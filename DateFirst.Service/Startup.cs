using Microsoft.Owin;
[assembly: OwinStartup(typeof(DateFirst.Service.Startup))]

namespace DateFirst.Service
{
    using System.Web.Http;
    using Owin;

    using Ninject.Web.Common.OwinHost;
    using Ninject.Web.WebApi.OwinHost;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            app.UseNinjectMiddleware(() => NinjectConfig.CreateKernel.Value);
            app.UseNinjectWebApi(config);
        }
    }
}
