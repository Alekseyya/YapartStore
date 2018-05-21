using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YapartStore.UI.ViewModels
{
    public class ProductViewModel
    {
        public string Article { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<PictureViewModel> Pictures { get; set; }
    }
}