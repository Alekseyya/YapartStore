using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
   public class CartLine
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public string Article { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }  

    }

    public class CartLineConfiguration : EntityTypeConfiguration<CartLine>
    {
        public CartLineConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(x => x.Article).IsRequired();
            Property(x => x.Descriptions).IsOptional();
            Property(x => x.Price).IsRequired();
            Property(x => x.Quantity).IsRequired();
        }
    }
}
