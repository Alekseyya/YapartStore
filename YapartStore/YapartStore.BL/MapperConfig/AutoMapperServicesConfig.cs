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
                cfg.AddProfile(new PictureProfile());
                cfg.AddProfile(new OrderProfile());
                cfg.AddProfile(new OrderItemProfile());
            });

        }

        public class BrandProfile :Profile
        {
            public BrandProfile()
            {
                CreateMap<BrandDTO, Brand>();
                CreateMap<Brand, BrandDTO>()
                    .ForMember(br => br.Products, opt => opt.Ignore()).ReverseMap();
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

        public class PictureProfile : Profile
        {
            public PictureProfile()
            {
                CreateMap<Picture, PictureDTO>();
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

        public class ProductWithoutBrandProfile : Profile
        {
            public ProductWithoutBrandProfile()
            {
                CreateMap<Product, ProductDTO>()
                    .ForMember(x => x.Brand, opt => opt.Ignore());
            }
        }

        public class ProductWithoutCategoryProfile : Profile
        {
            public ProductWithoutCategoryProfile()
            {
                CreateMap<Product, ProductDTO>()
                    .ForMember(x => x.Category, opt => opt.Ignore()).PreserveReferences();
            }
        }
        public class OrderProfile : Profile
        {
            public OrderProfile()
            {
                CreateMap<Order, OrderDTO>();
                CreateMap<OrderDTO, Order>();
            }
        }
        public class OrderItemProfile : Profile
        {
            public OrderItemProfile()
            {
                CreateMap<OrderItem, OrderItemDTO>();
                CreateMap<OrderItemDTO, OrderItem>();
            }
        }

        public class ProductWithoutBrandAndCategoryProfile: Profile
        {
            public ProductWithoutBrandAndCategoryProfile()
            {
                CreateMap<Product, ProductDTO>()
                    .ForMember(x => x.Brand, opt => opt.Ignore())
                    .ForMember(x => x.Category, opt => opt.Ignore())
                    .PreserveReferences();
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
