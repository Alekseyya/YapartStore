using System.Collections.Generic;


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