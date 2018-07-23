using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
   public class ModelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Years { get; set; }
        public string PicturePath { get; set; }
        public IList<ModificationDTO> Modifications { get; set; } = new List<ModificationDTO>();
    }
}
