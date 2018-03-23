
using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SectionDTO Section { get; set; }
        public ICollection<ProductDTO> Products{ get; set; } = new List<ProductDTO>();
    }

}