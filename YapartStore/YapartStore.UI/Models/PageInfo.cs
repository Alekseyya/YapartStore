using System;
using System.Collections.Generic;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Models
{
    public class PageInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        public int TotalPages
        {
            get { return (int) Math.Ceiling((decimal) TotalItems / PageSize); }
        }
    }

    public class CatalogViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}