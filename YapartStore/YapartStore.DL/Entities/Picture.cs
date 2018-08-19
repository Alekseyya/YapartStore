using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YapartStore.DL.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime UpdateTimestamp { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        
        public Mark Mark { get; set; }

        public Model Model { get; set; }
        public Modification Modification { get; set; }
        
        public virtual Brand Brand { get; set; }
    }
    public class PictureConfiguration : EntityTypeConfiguration<Picture>
    {
        public PictureConfiguration()
        {
            HasKey(x => x.Id);
            
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            HasRequired(p => p.Model).WithOptional();
            HasRequired(p => p.Mark).WithOptional();

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.Path)
                .IsRequired();

            Property(x => x.UpdateTimestamp)
                .IsRequired();
            Property(x => x.ProductId).IsOptional();
            HasOptional(x => x.Product);
        }
    }
}
