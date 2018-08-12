using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.IO.Pipes;

namespace YapartStore.DL.Entities
{
   public class ProductModification
    {
        public int ProductId { get; set; }
        public int ModificationId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Modification Modification { get; set; }
    }

    public class ProductModificationConfiguration : EntityTypeConfiguration<ProductModification>
    {
        public ProductModificationConfiguration()
        {
            HasKey(x => new { x.ProductId , x.ModificationId});
        }
    }
}
