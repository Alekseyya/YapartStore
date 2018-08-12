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
        public virtual Picture Picture { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }

    public class ModificationConfiguration : EntityTypeConfiguration<Modification>
    {
        public ModificationConfiguration()
        {
            HasOptional(x => x.Picture).WithRequired(x => x.Modification);
        }
    }
}
