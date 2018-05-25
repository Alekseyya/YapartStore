using System;
using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string ShippingMethod { get; set; }
        public string PaymentMethod { get; set; }

        public Guid ClientGuid { get; set; }
        public DateTime CreationTime { get; set; }

        public string City { get; set; }
        public string Phone { get; set; }

        public DateTime ShippedDate { get; set; }
        public string Comment { get; set; }


        public bool IsSent { get; set; }
        public bool IsClosed { get; set; }

        public virtual ICollection<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();
    }
}
