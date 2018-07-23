using Autofac;
using YapartStore.BL.Services;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.BL.DI
{
    public class AutofacWebApiRegister
    {
        public static void RegisterWebApiServices(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<BrandService>().As<IBrandService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<GroupService>().As<IGroupService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<SectionService>().As<ISectionService>();
            builder.RegisterType<PictureService>().As<IPictureService>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<OrderItemService>().As<IOrderItemService>();
            builder.RegisterType<MarkService>().As<IMarkService>();
            builder.RegisterType<ModelService>().As<IModelService>();
            builder.RegisterType<ModificationService>().As<IModificationService>();
        }

    }
}
