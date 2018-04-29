
using System.Collections.Generic;
using YapartStore.UI.Models;

namespace YapartStore.UI.ViewModels
{
    public class CapsCatalogViewModel
    {
        public IEnumerable<CapViewModel> Products { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}