using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Modification
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int? ModelId { get; set; }
        public Model Model { get; set; }
        public int Sort { get; set; }
        public ICollection<Variant> Variants { get; set; } = new List<Variant>();
    }
    public class ModificationConfiguration : EntityTypeConfiguration<Modification>
    {
        public ModificationConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();
            HasMany(x => x.Variants);
        }
    }
}
