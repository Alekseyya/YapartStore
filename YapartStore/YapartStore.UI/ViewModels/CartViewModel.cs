using System;
using System.Collections.Generic;

namespace YapartStore.UI.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public ICollection<ProductViewModel> Lines { get; set; }
    }
}