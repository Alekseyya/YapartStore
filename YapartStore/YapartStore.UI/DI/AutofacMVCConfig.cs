using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using YapartStore.UI.Services;
using YapartStore.UI.Services.Base;

namespace YapartStore.UI.DI
{
    public class AutofacMvcConfig
    {
        public static void ConfigureBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<BrandService>().As<IBrandService>();
            builder.RegisterType<ModelService>().As<IModelService>();
            builder.RegisterType<MarkService>().As<IMarkService>();
            builder.RegisterType<ModificationService>().As<IModificationService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        
    }
}