using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace YapartStore.DL.Entities
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //show on main window
        public bool Show{ get; set; }
        public ICollection<Model> Models { get; set; } = new List<Model>();
    }

    public class MarkConfiguration : EntityTypeConfiguration<Mark>
    {
        public MarkConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name).IsRequired();
            HasMany(x => x.Models);
        }
    }
}
