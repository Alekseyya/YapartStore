using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace YapartStore.DL.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

    }
    public class CartConfiguration : EntityTypeConfiguration<Cart>
    {
        public CartConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.UserId)
                .IsRequired();
            HasMany(x => x.Lines);
        }
    }
}
