
using System.Collections.Generic;
using System.Web.Mvc;
using YapartStore.UI.Models;

namespace YapartStore.UI.ViewModels
{
    public class CapsCatalogViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public PageInfo PageInfo { get; set; }
        public int SelectedId { get; set; }
        public IEnumerable<SelectListItem> CapsSize { get; set; }
    }
}