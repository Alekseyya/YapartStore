using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace YapartStore.DL.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Years { get; set; }

        public int? MarkId { get; set; }
        public Mark Mark { get; set; }
        
        public ICollection<Modification> Modifications { get; set; } = new List<Modification>();
    }
    public class ModelConfiguration : EntityTypeConfiguration<Model>
    {
        public ModelConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();
            HasMany(x => x.Modifications);
        }
    }
}
