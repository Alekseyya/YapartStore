using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.DL.Entities;

namespace YapartStore.BL.MapperConfig
{
    public static class AutoMapperServicesConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new BrandProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new GroupProfile());
                cfg.AddProfile(new SectionProfile());                
            });

        }

        public class BrandProfile :Profile
        {
            public BrandProfile()
            {
                CreateMap<BrandDTO, Brand>();
                CreateMap<Brand, BrandDTO>();
            }
        }

        public class CategoryProfile : Profile
        {
            public CategoryProfile()
            {
                CreateMap<CategoryDTO, Category>();
                CreateMap<Category, CategoryDTO>();
            }
        }
        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<ProductDTO, Product>();
                CreateMap<Product, ProductDTO>();
            }
        }
        public class GroupProfile : Profile
        {
            public GroupProfile()
            {
                CreateMap<GroupDTO, Group>();
                CreateMap<Group, GroupDTO>();
            }
        }

        public class SectionProfile : Profile
        {
            public SectionProfile()
            {
                CreateMap<SectionDTO, Section>();
                CreateMap<Section, SectionDTO>();
            }
        }
    }
}
