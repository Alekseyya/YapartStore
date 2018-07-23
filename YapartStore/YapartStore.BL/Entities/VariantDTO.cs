using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
    public class VariantDTO
    {
        public int Id { get; set; }
        public ModificationDTO Modification { get; set; }
        public IList<ProductDTO> Products { get; set; } = new List<ProductDTO>();
    }
}
