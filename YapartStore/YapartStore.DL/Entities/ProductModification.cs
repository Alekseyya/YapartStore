using System.IO.Pipes;

namespace YapartStore.DL.Entities
{
   public  class ProductModification
    {
        public int ProductId { get; set; }
        public int ModificationId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Modification Modification { get; set; }
    }
}
