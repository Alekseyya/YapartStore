using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        public int? ModificationId { get; set; }
        public Modification Modification{ get; set; }
        public ICollection<Product> Products{ get; set; } = new List<Product>();
    }
    public class VariantConfiguration : EntityTypeConfiguration<Modification>
    {
        public VariantConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();
            
        }
    }
}
