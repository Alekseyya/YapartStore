using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.DL.Entities;

namespace YapartStore.BL.MapperConfig
{
    public class AutoMapperServicesConfig
    {
        public class BrandProfile :Profile
        {
            public BrandProfile()
            {
                CreateMap<BrandDTO, Brand>();
            }
        }

        public class CategoryProfile : Profile
        {
            public CategoryProfile()
            {
                CreateMap<CategoryDTO, Category>();
            }
        }
        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<ProductDTO, Product>();
            }
        }
        public class GroupProfile : Profile
        {
            public GroupProfile()
            {
                CreateMap<GroupDTO, Group>();
            }
        }

        public class SectionProfile : Profile
        {
            public SectionProfile()
            {
                CreateMap<SectionDTO, Section>();
            }
        }
    }
}
