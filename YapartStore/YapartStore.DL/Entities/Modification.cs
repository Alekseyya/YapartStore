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
        public string Years { get; set; }
        public int Sort { get; set; }
        public string Url { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<ProductModification> ProductModifications { get; set; } = new List<ProductModification>();
    }

    public class ModificationConfiguration : EntityTypeConfiguration<Modification>
    {
        public ModificationConfiguration()
        {
            HasOptional(x => x.Picture).WithRequired(x => x.Modification);
            HasMany(x => x.ProductModifications)
                .WithRequired().HasForeignKey(x => x.ModificationId);
        }
    }
}
