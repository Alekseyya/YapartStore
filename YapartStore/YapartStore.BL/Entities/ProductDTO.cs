using System.ComponentModel.DataAnnotations;

namespace YapartStore.BL.Entities
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Item description limit exceeded!")]
        public string Descriptions { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+(\.[0-9][0-9]?)?", ErrorMessage = "Invalid price")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Item article limit exceeded!")]
        public string Article { get; set; }

        public BrandDTO Brand { get; set; }
        public CategoryDTO Category { get; set; }
    }

}