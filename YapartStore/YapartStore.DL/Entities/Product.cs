
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }

        public int? BrandId { get; set; }
        public Brand Brand { get; set; }

        public int? CategoryId { get; set;} 
        public Category Category { get; set; }

    }
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Article)
                .IsRequired().HasMaxLength(50);
            Property(x => x.Descriptions).IsRequired();
            Property(x => x.Price).HasPrecision(10, 2);
        }
    }
}
