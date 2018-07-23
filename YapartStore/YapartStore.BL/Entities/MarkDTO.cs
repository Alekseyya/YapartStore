using System.Collections.Generic;

namespace YapartStore.BL.Entities
{
   public class MarkDTO
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Show { get; set; }
            public string PicturePath { get; set; }
            public IList<ModelDTO> Models { get; set; } = new List<ModelDTO>();
    }
}
