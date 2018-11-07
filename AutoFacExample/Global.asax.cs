using Autofac;
using Autofac.Integration.Mvc;
using AutoFacExample.Domain.Service.Abstract;
using AutoFacExample.Domain.Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutoFacExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ExampleService>().As<IExampleService>();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterFilterProvider();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
