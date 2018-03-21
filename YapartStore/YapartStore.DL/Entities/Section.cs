using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }

    public class SectionConfiguration : EntityTypeConfiguration<Section>
    {
        public SectionConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name).IsRequired();
            HasMany(x => x.Categories);
        }
    }
}