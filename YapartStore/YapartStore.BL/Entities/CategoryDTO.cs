
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YapartStore.BL.Entities
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public bool Show { get; set; }
        public ICollection<ProductDTO> Products{ get; set; } = new List<ProductDTO>();
    }

}