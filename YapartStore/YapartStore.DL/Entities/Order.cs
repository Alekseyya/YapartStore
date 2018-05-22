using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Order
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


        public bool IsSent{ get; set; }
        public bool IsClosed { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        
    }
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.ShippingMethod)
                .IsRequired();

            Property(x => x.PaymentMethod)
                .IsOptional();

            Property(x => x.CreationTime)
                .HasColumnType("datetime2");

            Property(x => x.ShippedDate)
                .HasColumnType("datetime2");
        }
    }
}
