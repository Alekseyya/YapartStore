using YapartStore.UI.Services.Base;

namespace YapartStore.UI.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandService _brandService;

        public BrandService(IBrandService brandService)
        {
            _brandService = brandService;
        }
    }
}