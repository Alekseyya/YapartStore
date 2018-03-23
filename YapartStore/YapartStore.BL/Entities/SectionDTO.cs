using System.Collections;
using System.Collections.Generic;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Entities
{
    public class SectionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupDTO Group { get; set; }
        public ICollection<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
    }
}