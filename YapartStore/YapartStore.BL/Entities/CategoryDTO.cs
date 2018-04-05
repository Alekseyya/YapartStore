
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YapartStore.BL.Entities
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must be specified brand.")]
        [StringLength(30, ErrorMessage = "Brand name is too long.")]
        public string Name { get; set; }

        public SectionDTO Section { get; set; }
        public ICollection<ProductDTO> Products{ get; set; } = new List<ProductDTO>();
    }

}