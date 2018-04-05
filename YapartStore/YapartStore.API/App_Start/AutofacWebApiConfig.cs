using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using YapartStore.BL.DI;

namespace YapartStore.API.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Initialize()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterWebApiModelBinderProvider();

            AutofacWebApiRegister.RegisterWebApiServices(builder);


            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }
    }
}