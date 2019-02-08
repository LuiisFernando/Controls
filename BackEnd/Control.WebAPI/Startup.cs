using Control.Infra.CrossCutting.IoC;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(Control.WebAPI.Startup))]

namespace Control.WebAPI
{
    public class Startup
    {
        public static Container Container = new Container();

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //Injeção de Dependencia (SimpleInjector)
            Container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            BootStrapper.RegisterServices(Container);

            Container.RegisterSingleton(() =>
            {
                if (HttpContext.Current != null && HttpContext.Current.Items["owin.Environment"] == null && Container.IsVerifying)
                    return new OwinContext().Authentication;

                return HttpContext.Current.GetOwinContext().Authentication;

            });

            Container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            Container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Container);
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Container);

            app.UseCors(CorsOptions.AllowAll);
        }
    }
}
