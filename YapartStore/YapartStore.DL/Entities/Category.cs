using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? SectionId { get; set; }
        public Section Section { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            HasMany(x => x.Products);
        }
    }
}