using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
    public class ModificationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public IList<VariantDTO> Variants { get; set; } = new List<VariantDTO>();
    }
}
