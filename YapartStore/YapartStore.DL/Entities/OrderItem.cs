using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class OrderItem
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
    public class OrderItemConfiguration : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(x => x.ClientGuid)
                .IsRequired();
            Property(x => x.CreationTime)
                .HasColumnType("datetime2");

        }
    }
}
