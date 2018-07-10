
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Article { get; set; }

        public string ShortArticle { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int DaysDelivery { get; set; }
        //cross price
        public decimal OldPrice { get; set; }
        //show to popular or not
        public bool Popular { get; set; }
        // additional characteristic
        public string Characteristic { get; set; }
        //for seo
        public string Brief { get; set; }
        //see on layout
        public bool Show { get; set; }
        //see in discount tab
        public bool Discount { get; set; }
        public string Keywords { get; set; }
        public bool RemoveMarketplace { get; set; }
        
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public ICollection<Variant> Variants { get; set; } = new List<Variant>();

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
