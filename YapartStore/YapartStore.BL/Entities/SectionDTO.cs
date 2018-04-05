using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YapartStore.BL.Entities
{
    public class SectionDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Item name limit exceeded!")]
        public string Name { get; set; }
        public GroupDTO Group { get; set; }
        public ICollection<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
    }
}