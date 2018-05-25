using System;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Entities
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public virtual Order OrderId { get; set; }
        public string Articul { get; set; }
        public string Description { get; set; }

        public decimal PriceWithDiscount { get; set; }

        public int Quantity { get; set; }
        public string Comment { get; set; }

        public bool IsClosed { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStatusComment { get; set; }
        public Guid ClientGuid { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
