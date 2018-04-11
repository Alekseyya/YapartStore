
using System.Collections.Generic;

namespace YapartStore.UI.ViewModels
{
    public class BrandViewModel
    {
        public string Name { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}