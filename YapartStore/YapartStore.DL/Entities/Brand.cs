using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        
        public virtual Picture Picture { get; set; }
    }
    public class BrandConfiguration : EntityTypeConfiguration<Brand>
    {
        public BrandConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            HasMany(x => x.Products);
           // HasOptional(p => p.Picture).WithOptionalPrincipal(p=>p.Brand);
            HasOptional(s => s.Picture).WithRequired(ad => ad.Brand);
        }
    }
}